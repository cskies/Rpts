using System;
using System.Collections.Generic;
using System.Linq;

using System.Xml.Schema;
using System.Xml.Linq;
using System.IO;
using System.Configuration;
using System.Xml.Serialization;
using GSW.BPO.Common.ReinfClasses;

namespace GSW.BPO.Common
{
    public class TransformXmlToClass
    {
        public static dynamic xmlToClass(string _fileName)
        {
            try
            {
                //if (ValidateXmlFormat(_fileName))
                //{
                    var typeClass = GetTypeOfStructure(_fileName);

                    switch (_fileName)
                    {
                        case string arq when arq.Contains("R-2010_"):
                            return Deserialize<GSW.BPO.Common.ReinfClasses.Tomador.Reinf>(_fileName);
                        case string arq when arq.Contains("R-2020_"):
                            return Deserialize<GSW.BPO.Common.ReinfClasses.Prestador.Reinf>(_fileName);
                        default:
                            return null;
                    }

            //}
            //    else
            //    {
            //    throw new System.InvalidOperationException($"Arquivo:{_fileName} não corresponde ao formato de XSD existente.");
            //}
        }
            catch (Exception ex)
            {

                throw;
            }

        }
        public static bool ValidateXmlFormat(string _fileName)
        {

            List<Tuple<String, String>> validations = new List<Tuple<String, String>>();

            try
            {
             
                    XmlSchemaSet schemas = new XmlSchemaSet();

                    var schemaFileName = GetXsdFilePath(_fileName);
                    var schemaNamespace = GetXsdNameSpace(schemaFileName);

                    schemas.Add(schemaNamespace, schemaFileName);

                    schemaFileName = GetXsdFilePath("xmldsig-core-schema_v1.01");
                    schemaNamespace = GetXsdNameSpace(schemaFileName);

                    schemas.Add(@"http://www.w3.org/2000/09/xmldsig#", schemaFileName);
                    //schemas.Add(schemaNamespace, schemaFileName);

                XDocument doc = XDocument.Load(_fileName);
                    //string msg = "";
                    //doc.Validate(schemas, (o, e) => {
                    //    msg += e.Message + Environment.NewLine;
                    //});

                    doc.Validate(schemas, (o, e) => {
                        validations.Add(new Tuple<string, string>(e.Severity.ToString(), e.Message));
                    }
                                );

                    var countError = validations.Where(x => x.Item1 == "Error").Count();

                var teste = validations.Where(x => x.Item1 == "Error").ToList();

                    return (countError > 0 ? false : true);
                

                
            }
            catch (Exception ex)
            {

                throw;
            }

            

           
        }
        public static bool ValidateXmlFormatNF40(string _textOfNF40)
        {

            List<Tuple<String, String>> validations = new List<Tuple<String, String>>();

            try
            {

                XmlSchemaSet schemas = new XmlSchemaSet();

                var schemaFileName = GetXsdFilePath("nfe_v4.00");
                var schemaNamespace = GetXsdNameSpace(schemaFileName);

                schemas.Add(schemaNamespace, schemaFileName);

                schemaFileName = GetXsdFilePath("xmldsig-core-schema_v1.01");
                schemaNamespace = GetXsdNameSpace(schemaFileName);

                schemas.Add(@"http://www.w3.org/2000/09/xmldsig#", schemaFileName);

                schemaFileName = GetXsdFilePath("leiauteNFe_v4.00");
                schemaNamespace = GetXsdNameSpace(schemaFileName);

                schemas.Add(schemaNamespace, schemaFileName);

                schemaFileName = GetXsdFilePath("tiposBasico_v4.00");
                schemaNamespace = GetXsdNameSpace(schemaFileName);

                schemas.Add(schemaNamespace, schemaFileName);

                XDocument doc = XDocument.Parse(_textOfNF40);
              
                //string msg = "";
                //doc.Validate(schemas, (o, e) => {
                //    msg += e.Message + Environment.NewLine;
                //});

                doc.Validate(schemas, (o, e) => {
                    validations.Add(new Tuple<string, string>(e.Severity.ToString(), e.Message));
                }
                            );

                var countError = validations.Where(x => x.Item1 == "Error").Count();

                return (countError > 0 ? false : true);



            }
            catch (Exception ex)
            {

                throw;
            }




        }
        public static Type GetTypeOfStructure(string _fileName)
        {

            try
            {
                switch (_fileName)
                {
                    case string arq when arq.ToLower().Contains("R-2020_"):
                        return typeof(GSW.BPO.Common.ReinfClasses.Prestador.Reinf);
                    case string arq when arq.ToLower().Contains("R-2010_"):
                        return typeof(GSW.BPO.Common.ReinfClasses.Tomador.Reinf);
                   
                    default:
                        return null;
                }

                return null;
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public static string GetXsdFilePath(string _fileName)
        {
            try
            {
                var xsdPath = new DirectoryInfo(ConfigurationSettings.AppSettings["XsdPath"].ToString());

                switch (_fileName)
                {
                    case string arq when arq.Contains("R-2020_"):
                        return Path.Combine(xsdPath.FullName, "evtPrestadorServicos-v1_03_02.xsd");

                    case string arq when arq.Contains("R-2010_"):
                        return Path.Combine(xsdPath.FullName, "evtTomadorServicos-v1_03_02.xsd");

                    case string arq when arq.Contains("xmldsig-core-schema_v1.01"):
                        return Path.Combine(xsdPath.FullName, "xmldsig-core-schema_v1.01.xsd");

                    default:
                        return null;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public static string GetXsdNameSpace(string _xsdFilePath)
        {
            try
            {
                XElement elemet = XElement.Load(_xsdFilePath);
                string elementNamespace = elemet.GetDefaultNamespace().NamespaceName;
                return elementNamespace;

            }
            catch (Exception ex )
            {

                throw;
            }


        }
        public static T Deserialize<T>(string input) where T : class
        {

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                using (StreamReader reader = new StreamReader(input))
                {

                    var classContent = (T)serializer.Deserialize(reader);
                    reader.Close();

                    return classContent;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            //XmlSerializer serializer = new XmlSerializer(typeof(ImpIfaceDatasOutErpCollection));

            //StreamReader reader = new StreamReader(input);
            //var cars = (ImpIfaceDatasOutErpCollection)serializer.Deserialize(reader);
            //reader.Close();

        }
        public static T DeserializeString<T>(string input) where T : class
        {

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                using (StringReader reader = new StringReader(input))
                {

                    var classContent = (T)serializer.Deserialize(reader);
                    reader.Close();

                    return classContent;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            //XmlSerializer serializer = new XmlSerializer(typeof(ImpIfaceDatasOutErpCollection));

            //StreamReader reader = new StreamReader(input);
            //var cars = (ImpIfaceDatasOutErpCollection)serializer.Deserialize(reader);
            //reader.Close();

        }

        public static string Serialize<T>(T ObjectToSerialize)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());

                using (StreamWriter textWriter = new StreamWriter(@"c:\teste\x.txt"))
                {
                    xmlSerializer.Serialize(textWriter, ObjectToSerialize);
                    return textWriter.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
