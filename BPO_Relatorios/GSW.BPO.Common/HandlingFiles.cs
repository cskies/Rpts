
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;


namespace GSW.BPO.Common
{
    public class HandlingFiles
    {
        public static IList<FileInfo> CheckSplitFiles(string _tipoDeEstrutura, IList<FileInfo> _arquivos)
        {
            int LinesPerFile = 0;
            bool FileMustBeSplited = false;

            try
            {
                try
                {
                    FileMustBeSplited = Convert.ToBoolean(ConfigurationSettings.AppSettings["FileMustBeSplited"].ToString());
                    LinesPerFile = Int32.Parse(ConfigurationSettings.AppSettings["LinesPerFile"].ToString());

                }
                catch (Exception)
                {
                    FileMustBeSplited = false;
                    LinesPerFile = 0;

                    return _arquivos;
                }

                if ((FileMustBeSplited) && (LinesPerFile > 0))
                {
                    return ExecuteSplitFiles(LinesPerFile, _tipoDeEstrutura, _arquivos);
                }
                else
                {
                    return _arquivos;
                }
            }
            catch (Exception)
            {

                throw;
            }
            

        }
        private static IList<FileInfo> ExecuteSplitFiles(int _LinesPerFile, string _tipoDeEstrutura, IList<FileInfo> _files)
        {
            string[] fileLines;
            int qtdFiles = 0;
            List<FileInfo> filesRtrn = new List<FileInfo>();

            try
            {
                var baseDirectory = new DirectoryInfo(ConfigurationSettings.AppSettings["BaseDirectory"].ToString());
                foreach (var diretorio in baseDirectory.GetDirectories().Where(x => x.Name.ToUpper() == _tipoDeEstrutura.ToUpper()))
                {
                    var textFilesDirectory = $@"{diretorio.FullName}\TXT";
                    //var files = Leitura.ListaDeArquivosTexto(textFilesDirectory);
                    foreach (var textFile in _files)
                    {
                        fileLines = System.IO.File.ReadAllLines(textFile.FullName);

                        try
                        {
                            double div = (double)fileLines.Count() / (double)_LinesPerFile;
                            qtdFiles = (int)Math.Ceiling((double)(div));
                        }
                        catch
                        {
                            qtdFiles = 0;
                        }

                        if (qtdFiles > 1)
                        {
                            var filesSplited = SplitFile(textFile.FullName, fileLines, _LinesPerFile);
                            foreach (var fileSpl in filesSplited)
                            {
                                filesRtrn.Add(fileSpl);
                            }
                        }
                        else
                        {
                            filesRtrn.Add(textFile);
                        }
                            

                    }
                }

                return filesRtrn;

            }
            catch (Exception)
            {

                throw;
            }
        }
        private static IList<FileInfo> SplitFile(string _fileFullName, string[] _fileLines, int _LinesPerFile)
        {
            bool MainFileMustBeMoved = false;
            List<FileInfo> filesRtrn = new List<FileInfo>();

            try
            {
                var fileName = Path.GetFileName(_fileFullName);
                var pathFile = Path.GetDirectoryName(_fileFullName);


                int i = 0;
                //var filesSplited = from line in _fileLines
                //                 group line by i++ % _qtdFiles into part
                //                select part;

                //var filesSplited = from iPos in Enumerable.Range(0, _fileLines.Length)
                //                  group _fileLines[iPos] by iPos / _qtdFiles;

                //var filesSplited = from iPos in Enumerable.Range(0, _fileLines.Length)
                //                   group _fileLines[iPos] by iPos % _qtdFiles;

                var skip = 0;
                var take = _LinesPerFile;
                
                var iPart = 1;

                while (skip < _fileLines.Length)
                {
                    //var count = newFile.ToList();
                    var newFileNameFullPath = Path.Combine(pathFile, fileName.Replace(".txt", $"_{iPart.ToString()}.txt"));

                    var newFile = _fileLines.Skip(skip).Take(take);

                    File.WriteAllLines(newFileNameFullPath, newFile);

                    var newFileInfo = new FileInfo(newFileNameFullPath);
                    filesRtrn.Add(newFileInfo);

                    iPart += 1;
                    skip += take;

                    MainFileMustBeMoved = true;
                }

                if (MainFileMustBeMoved)
                    MoveFileToBackupArea(_fileFullName);

                return filesRtrn;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private static void MoveFileToBackupArea(string _fileFullName)
        {
            try
            {
                var FileFullNameBackupArea = _fileFullName.Replace("TXT", "Backup");

                if (File.Exists(FileFullNameBackupArea))
                    File.Delete(FileFullNameBackupArea);

                File.Move(_fileFullName, FileFullNameBackupArea);
            }
            catch (Exception ex)
            {
                //var appLog = new AppLog();
                //appLog.Error(new Log { Tabela = null, Mensagem = $"Erro: (MoveFileToBackupArea) {_fileFullName}", Exception = ex });
                //MoveFileToErrorArea(_fileFullName);

            }

            
        }
        private static void MoveFileToErrorArea(string _fileFullName)
        {
            try
            {
                var FileFullNameErrorArea = _fileFullName.Replace("TXT", "ERRO");

                if (File.Exists(FileFullNameErrorArea))
                    File.Delete(FileFullNameErrorArea);

                File.Move(_fileFullName, FileFullNameErrorArea);

            }
            catch (Exception ex)
            {
                //var appLog = new AppLog();
                //appLog.Error(new Log { Tabela = null, Mensagem = $"Erro: (MoveFileToErrorArea) {_fileFullName}", Exception = ex });
            }
        }

        public static bool FileIsLocked(string _filePath)
        {
            try
            {
                using (FileStream fileStream = File.Open(_filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                    if (fileStream != null) fileStream.Close();  
                }
            }
            catch (Exception ex)
            {
                return true;
            }
            finally
            { }
            return false;
        }
        public static void VerifyIfNeedToCheckLineBreaks(string _typeOfStructure, IList<FileInfo> _files)
        {
            bool CheckLineBreaksInMidleOfFile = false;
            int FileColumsInEachLine = 0;
            Dictionary<string, int> dictFileNamesAndCols = new Dictionary<string, int>();

            try
            {
                try
                {
                    CheckLineBreaksInMidleOfFile = Convert.ToBoolean(ConfigurationSettings.AppSettings["CheckLineBreaksInMidleOfFile"].ToString());
                    //FileColumsInEachLine = Convert.ToInt32(ConfigurationSettings.AppSettings["FileColumnsInEachLine"].ToString());

                    var LineBreaksFilesToBeChecked = ConfigurationSettings.AppSettings["LineBreaksFilesToBeChecked"].ToString();
                    string[] fileNamesAndColumns = LineBreaksFilesToBeChecked.Split(new[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                    dictFileNamesAndCols = fileNamesAndColumns.Select(item => item.Split('=')).ToDictionary(s => s[0].ToUpper(), s => Convert.ToInt32(s[1]));


                }
                catch (Exception)
                {
                    CheckLineBreaksInMidleOfFile = false;
                }

                if (CheckLineBreaksInMidleOfFile)
                {
                    CheckLineBreaksInMidleOfFiles(_typeOfStructure, _files, dictFileNamesAndCols);
                }
              
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void CheckLineBreaksInMidleOfFiles(string _typeOfStructure, IList<FileInfo> _files, Dictionary<string, int> dictFileNamesAndCols)
        {
            try
            {
                foreach (var textFile in _files)
                {

                    var fileName = Path.GetFileNameWithoutExtension(textFile.ToString());
                    var fileWithoutDigits = new String(fileName.Where(c => !Char.IsDigit(c)).ToArray());
                    if (dictFileNamesAndCols.ContainsKey(fileWithoutDigits))
                    {
                        // get columns from file
                        var columns = dictFileNamesAndCols[fileWithoutDigits];

                        if (columns > 0)
                            CheckFileBreaksInDescription(textFile.FullName, columns);
                    }
                    
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void CheckFileBreaksInDescription(string _pathFile, int _columnsPerRow)
        {
            char[] character = new char[1];
            int asciiCode;
            int countSeparator = 0;
            bool fileHasProblem = false;

            string line = "";
            int qtdSeparators = _columnsPerRow - 1;
            List<string> newLines = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(_pathFile))
                {

                    while (sr.Peek() >= 0)
                    {
                        sr.Read(character, 0, character.Length);
                        asciiCode = Convert.ToInt32(character[0]);

                        if (asciiCode == 42)
                        {
                            countSeparator += 1;
                        }

                        if ((countSeparator < qtdSeparators) && (asciiCode == 10 || asciiCode == 13))
                        {
                            fileHasProblem = true;
                        }

                        if ((countSeparator <= qtdSeparators) && (asciiCode != 10) && (asciiCode != 13))
                        {
                            line = line + character[0];
                        }
                        else
                        {
                            if ((countSeparator == qtdSeparators) && (asciiCode == 10 || asciiCode == 13))
                            {
                                line = line + character[0];
                            }
                        }


                        if (line.Length >= 2)
                        {
                            if ((Convert.ToInt32(line[line.Length - 2]) == 13) && (asciiCode == 10))
                            {
                                // write new line in new file
                                newLines.Add(line.Replace("\r\n",""));
                                countSeparator = 0;
                                line = "";
                            }
                        }


                    }
                }

                if (fileHasProblem)
                {
                    SaveNewFile(_pathFile, newLines);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private static void SaveNewFile(string _pathFile, List<string> _newLinesFromFile)
        {
            try
            {
                var fileExtension = Path.GetExtension(_pathFile);
                var FileFullNameRename = _pathFile.Replace(fileExtension, "_ErrQbLinha.txt");

                RenameFile(_pathFile, FileFullNameRename);
                File.WriteAllLines(_pathFile, _newLinesFromFile.ToArray());

                MoveFileToErrorArea(FileFullNameRename);

            }
            catch (Exception)
            {

                throw;
            }
        }
        private static void RenameFile(string _fileFullName, string _fileRenameTo)
        {
            try
            {

                if (File.Exists(_fileRenameTo))
                    File.Delete(_fileRenameTo);

                File.Move(_fileFullName, _fileRenameTo);

                if (File.Exists(_fileFullName))
                    File.Delete(_fileFullName);

            }
            catch (Exception ex)
            {
                //var appLog = new AppLog();
                //appLog.Error(new Log { Tabela = null, Mensagem = $"Erro: (RenameFile) {_fileFullName}", Exception = ex });
            }
        }
    }
}
