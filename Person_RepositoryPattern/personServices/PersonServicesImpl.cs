using System.Collections.Generic;
using Models;
using Repository; 

namespace Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _repository;

        public PersonService(IPersonRepository repository)
        {
            _repository = repository;
        }

        public void AddPerson(Person person)
        {
            _repository.Add(person);
        }

        public void DeletePerson(int id)
        {
            _repository.Delete(id);
        }

        public List<Person> GetAllPersons()
        {
            return _repository.GetAll();
        }

        public Person GetPersonById(int id)
        {
            return _repository.GetById(id);
        }

        public void UpdatePerson(Person person)
        {
            _repository.Update(person);
        }
    }
}
