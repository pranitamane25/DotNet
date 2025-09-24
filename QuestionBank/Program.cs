using System.Reflection.Metadata.Ecma335;
using System.Text.Json;
using System.Xml.Serialization;
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

        //serialized data
        string jsonstring = JsonSerializer.Serialize(QB);
        Console.WriteLine("Serialized Data :" + jsonstring);

        //deserialized data

        QuestionBank QB2 = JsonSerializer.Deserialize<QuestionBank>(jsonstring);
        
        
        Console.WriteLine("Desrialized data");
                Console.WriteLine(QB2);

         Console.WriteLine($"Name={QB2.Name},Subject={QB2.Subject},TotalQuestion={QB2.TotalQuestion}");


    }

}

