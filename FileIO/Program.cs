using InsuranceApp.Models;
using InsuranceApp.Services;


Console.WriteLine("Insurance Policy System");

List<Policy> policies = new List<Policy>()
{
    new Policy(102, "rutuja", 60000),
    new Policy(103, "pranita", 80000),
    new Policy(104, "rutuja", 60000),
    new Policy(105, "pranita", 80000)
};
    
    
Console.WriteLine("\nOriginal Object");
Console.WriteLine(policies);



// Serialization
PolicyFileManager.SavePolicy(policies);



//Deserialization
List<Policy> LoadPolicies =
    PolicyFileManager.LoadPolicies();

Console.WriteLine("\nObject After Deserialization");

if (LoadPolicies != null)
{
    foreach (Policy policy in LoadPolicies)
    {
        Console.WriteLine(policy);
    }
}

