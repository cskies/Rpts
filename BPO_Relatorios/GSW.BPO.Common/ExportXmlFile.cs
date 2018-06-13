
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;

namespace GSW.BPO.Common
{
    public class ExportXmlFile
    {
        public static void Processamento(string _typeOfFolder)
        {
            var guidID = AplTrace.GenerateNewId();

            try
            {

                //var baseDirectory = new DirectoryInfo(directoryName.Name);
                var baseDirectory = new DirectoryInfo(ConfigurationSettings.AppSettings["BaseDirectory"].ToString());
                        
                foreach (var directory in baseDirectory.GetDirectories().Where(x => x.Name.ToUpper() == _typeOfFolder.ToUpper()))
                {
                    //var directoryOfTextFiles = $@"{directory.FullName}\XML";
                    var files = ReadXmlFiles.GetXmlFiles(directory.FullName);


                    foreach (var xmlFile in files)
                    {
                        try
                        {
                            // Verificacao de arquivo em uso
                            if (HandlingFiles.FileIsLocked(xmlFile.FullName) == false)
                            {
                                try
                                {
                                    var _class = TransformXmlToClass.xmlToClass(xmlFile.FullName);

                                    //if (WriteClassIntoBPCS(xmlFile, _class, guidID))
                                    //{
                                    //    BasicStructure.ModeFileToBackupArea(xmlFile, guidID);
                                    //}
                                }
                                catch (Exception)
                                {
                                    // BasicStructure.ModeFileToErrorArea(xmlFile, guidID);
                                }

                            }

                        }
                        catch (Exception ex)
                        {
                            AplTrace.InsertTrace(guidID, typeof(ExportXmlFile).Namespace, "(Processamento)", ex.Message);
                        }

                    }
                }
                   
                

            }
            catch (Exception ex)
            {
                AplTrace.InsertTrace(guidID, typeof(ExportXmlFile).Namespace, "(Processamento)", ex.Message);
            }

            
        }
        
        


    }
}