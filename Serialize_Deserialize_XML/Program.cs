// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.Serialization;


namespace Learn_Serialize_Deserialize_XML
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("SELAMAT BELAJAR XML SERIALIZE DAN DESERIALIZE\n\n");
            SerializeObject();

            Console.WriteLine("Processing the xml writer to xml file...");
            SerializeObjectToXMLFile();
            Console.WriteLine("Writing to xml file completed...");
        }

        private static void SerializeObject()
        {
            var member = new FT400InitialConfiguration()
            {
                Name = "John",
                Email = "jhon@gmail.com",
                Age = 22,
                JoiningDate = DateTime.Now,
                IsAlive = true
            };

            var xmlSerializer = new XmlSerializer(typeof(FT400InitialConfiguration));
            using (var writer = new StringWriter())
            {
                xmlSerializer.Serialize(writer, member);
                var xmlContent = writer.ToString();
                Console.WriteLine(xmlContent);
                
            }
        }

        private static void SerializeObjectToXMLFile()
        {
            var member = new FT400InitialConfiguration()
            {
                Name = "Gilang Peradilan Semu",
                Email = "jhon@gmail.com",
                Age = 22,
                JoiningDate = DateTime.Now,
                IsAlive = true
            };
            var xmlSerializer = new XmlSerializer(typeof(FT400InitialConfiguration));
            using (var writer = new StreamWriter(@"E:\Employee_Gilang\Learn_GitFLow\Serialize_Deserialize_XML\xml_serialize_result\resultMember1.xml"))
            {
                xmlSerializer.Serialize(writer, member);
            }
        }
    }
}