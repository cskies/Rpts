using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSW.BPO.Common
{
    public class AplTrace
    {
        public static void InsertTrace(Guid _RequestId, string _NameSpace, string _Description, string _Error)
        {
            if (Convert.ToBoolean(ConfigurationSettings.AppSettings["AplTrace"].ToString()))
            {
                var PathLogFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"AplTrace\\");

                bool folderExists = Directory.Exists(PathLogFile);
                if (!folderExists)
                    Directory.CreateDirectory(PathLogFile);

                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{ _RequestId.ToString()}.txt");
              
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("**************************************************");
                        sw.WriteLine("BPO Relatórios Services");
                        sw.WriteLine("**************************************************");

                    }
                }

                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("NameSpace   : " + _NameSpace);
                    sw.WriteLine("DateTime    : " + DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture));

                    if (!string.IsNullOrEmpty(_Description))
                        sw.WriteLine("Description : " + _Description);

                    if (!string.IsNullOrEmpty(_Error))
                        sw.WriteLine("ErrorDetail : " + _Error);

                    sw.WriteLine("--------------------------------------------------");
                }
            }

        }
        public static string CreateTraceQuoteHeader(dynamic _QuoteHeader)
        {

            string HeaderParameters = "";

            try
            {
                HeaderParameters += Environment.NewLine;
                HeaderParameters += Environment.NewLine;
                HeaderParameters += "*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-" + Environment.NewLine;
                HeaderParameters += "File name:         " + _QuoteHeader + Environment.NewLine;
                HeaderParameters += "*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-" + Environment.NewLine;

            }
            catch (Exception ex)
            {

            }
            return HeaderParameters;
        }

        public static System.Guid GenerateNewId()
        {
            return Guid.NewGuid();
        }
    }
}
