using System.Text.Json;
using SOLID_principles.Models;

namespace SOLID_principles.Repositories;

public class OperationsRepository
{
    public List<Operation>LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            return new List<Operation>();
        }
        string jsonOperations=File.ReadAllText(fileName);
        List<Operation>AllExistingOperations=JsonSerializer.Deserialize<List<Operation>>(jsonOperations)?? new List<Operation>();
        return AllExistingOperations;
    }

    public bool SaveToFile(string fileName, List<Operation> operations)
    {
        bool status = false;
        string jsonOperations=JsonSerializer.Serialize <List<Operation>>(operations);
        File.WriteAllText(fileName,jsonOperations);
        status=true;
        return status;
    }
}