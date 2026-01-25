using System.Collections.Generic;
using System.Linq;
using Models;

namespace Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly List<Person> _people = new List<Person>();

        public void Add(Person person)
        {
            _people.Add(person);
        }

        public void Delete(int id)
        {
            var person = GetById(id);
            if (person != null)
                _people.Remove(person);
        }

        public List<Person> GetAll()
        {
            return _people;
        }

        public Person GetById(int id)
        {
            return _people.FirstOrDefault(p => p.Id == id);
        }

        public void Update(Person person)
        {
            var existing = GetById(person.Id);
            if (existing != null)
            {
                existing.Name = person.Name;
                existing.Age = person.Age;
            }
        }
    }
}
