using System.Text.Json;
using System.Collections.Generic;
using  SOLID_principles.Publishers;
namespace SOLID_principles.Repositories;
public class AccountsRepository
{
    public List<Account> LoadFromFile(string fileName)
    {

        //DeSerialize code
         if (!File.Exists(fileName))
        {
            return new List<Account>();
        }
        string jsonAccounts=File.ReadAllText(fileName);
       
        List<Account> allExistingAccounts=JsonSerializer.Deserialize<List<Account>>(jsonAccounts)??new List<Account>();
        
        
        return allExistingAccounts;
        
    }
    public bool SaveToFile(string fileName,List<Account> accounts)
    {
        //Serialize code
        bool status=false;
        var options =
        new JsonSerializerOptions
        {
            WriteIndented=true
        };
        string jsonAccounts=JsonSerializer.Serialize <List<Account>>(accounts,options);
        File.WriteAllText(fileName,jsonAccounts);
        status=true;
        return status;
    }
}