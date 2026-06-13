using System.Text.Json;
using InsuranceApp.Models;

namespace InsuranceApp.Services;
public static class PolicyFileManager
{
    private static string filePath = "policy.json";

    // Serialization
    public static void SavePolicy (List<Policy>policies)
    {
        string jsonData =
            JsonSerializer.Serialize(
                policies,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

        File.WriteAllText(filePath, jsonData);

        Console.WriteLine("Policy saved successfully.");
    }

    // Deserialization
   public static List<Policy> LoadPolicies()
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return null;
        }

        string jsonData =
            File.ReadAllText(filePath);

        List<Policy> policies =
            JsonSerializer.Deserialize<List<Policy>>(jsonData);

        return policies;
    }

   
}