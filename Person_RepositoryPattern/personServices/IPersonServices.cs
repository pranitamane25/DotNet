using System.Collections.Generic;
using Models;

namespace Services
{
    public interface IPersonService
    {
        void AddPerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(int id);
        Person GetPersonById(int id);
        List<Person> GetAllPersons();
    }
}
