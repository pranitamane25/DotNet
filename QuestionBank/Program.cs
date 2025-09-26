
using System.Text.Json;
using System.Xml.Serialization;
using System;
using System.IO;
using HR;
class QuestionProgram
{
        public static void Main(String[] args)
        {
                QuestionBank QB = new QuestionBank();

                QB.Name = "physics";
                QB.Subject = "c# prog";
                QB.TotalQuestion = 20;

                Console.WriteLine(QB);


                //------JSON serialized data
                string jsonstring = JsonSerializer.Serialize(QB);
                Console.WriteLine("Serialized Data :" + jsonstring);

                //------JSON deserialized data

                QuestionBank QB2 = JsonSerializer.Deserialize<QuestionBank>(jsonstring);

                Console.WriteLine("Desrialized data");
                Console.WriteLine(QB2);

                Console.WriteLine($"Name={QB2.Name},Subject={QB2.Subject},TotalQuestion={QB2.TotalQuestion}");

                //--------XmlSerialization---------

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(QuestionBank));
                StringWriter writer = new StringWriter();
                xmlSerializer.Serialize(writer, QB);
                string xmlData = writer.ToString();
                Console.WriteLine("XML serialized data");
                Console.WriteLine(xmlData);


                //-----Xml Deserialization------
                StringReader reader = new StringReader(xmlData);
                QuestionBank QB3 = (QuestionBank)xmlSerializer.Deserialize(reader);
                Console.WriteLine("Deserialized data");
                Console.WriteLine($"Name={QB3.Name},Subject={QB3.Subject},TotalQuestion={QB3.TotalQuestion}");

                 }
}
