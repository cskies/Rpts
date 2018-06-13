using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GSW.BPO.Common
{
    public class ReadXmlFiles
    {

        public static IList<FileInfo> GetXmlFiles(string _fileDirectory)
        {
            var directory = new DirectoryInfo(_fileDirectory);
            var files = new List<FileInfo>();
            foreach (var file in directory.GetFiles("*.xml"))
            {
                if (HandlingFiles.FileIsLocked(file.FullName) == false)
                {
                    files.Add(file);
                }
            
            }
                
            return files;
        }
    }
}
