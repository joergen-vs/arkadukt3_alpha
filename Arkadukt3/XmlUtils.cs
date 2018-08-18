using no.arkivverket.standarder.addml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Arkadukt3
{
    class XmlUtils
    {

        public static addml ReadFromString(string xml)
        {
            return DeserializeFromString(xml);
        }

        public static addml ReadFromFile(string pathToFile)
        {
            string objectData = File.ReadAllText(pathToFile);
            return DeserializeFromString(objectData);
        }

        private static addml DeserializeFromString(string objectData)
        {
            var serializer = new XmlSerializer(typeof(addml));
            addml result = null;

            TextReader reader = null;
            try
            {
                reader = new StringReader(objectData);
                result = (addml)serializer.Deserialize(reader);
            }
            catch (InvalidOperationException e)
            {
                string error = e.Message + ": " + e.InnerException?.Message;
                Console.WriteLine(error);
            }
            finally
            {
                reader?.Close();
            }

            return result;
        }

        public static string WriteToString(addml _addml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(Type.GetType("no.arkivverket.standarder.addml"));

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, _addml);
                return textWriter.ToString();
            }
        }

        public static bool WriteToFile(String path, addml _addml)
        {
            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add("addml", "http://www.arkivverket.no/standarder/addml");
            namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

            var serializer = new XmlSerializer(Type.GetType("no.arkivverket.standarder.addml"));
            using (var stream = new StreamWriter(path, false, Encoding.UTF8))
            {
                serializer.Serialize(stream, _addml, namespaces);
            }
            return true;
        }
    }
}
