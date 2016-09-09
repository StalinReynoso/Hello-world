using System.Collections.Generic;

namespace ASS_Repository
{
    public interface IPersonRepository
    {
        List<Person> GetAllPerson();
        Person GetPersonById(int id);
        Person GetPersonByName(string name);
        void Update(Person person);
        void Delete(Person person);
        void Create(Person person);
    }
}