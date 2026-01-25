using System.Collections.Generic;
using Models;

namespace Repository
{
    public interface IPersonRepository
    {
        Person GetById(int id);
        List<Person> GetAll();
        void Add(Person person);
        void Update(Person person);
        void Delete(int id);
    }
}
