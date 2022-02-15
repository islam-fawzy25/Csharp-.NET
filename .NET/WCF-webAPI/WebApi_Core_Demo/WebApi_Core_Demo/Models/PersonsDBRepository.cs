using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Core_Demo.Models
{
    public class PersonsDBRepository : IPersonsInterface
    {
        private readonly PersonsDB _db;
        public PersonsDBRepository(PersonsDB context)
        {
            _db = context;
        }
        public Person AddPerson(Person newPerson)
        {
            _db.Persons.Add(newPerson);
            _db.SaveChanges();
            return newPerson;
        }

        public List<Person> AllPersons()
        {
            return _db.Persons.ToList();
        }

        public void DeletePerson(Person poorGuy)
        {
            _db.Persons.Remove(poorGuy);
            _db.SaveChanges();
        }

        public Person EditPerson(Person personToBeEdited)
        {
            Person personInDatabase = _db.Persons.Find(personToBeEdited.Id);
            if (personInDatabase !=null)
            {
                personInDatabase.FirstName = personToBeEdited.FirstName;
                personInDatabase.LastName = personToBeEdited.LastName;
                personInDatabase.City = personToBeEdited.City;
                _db.Persons.Update(personInDatabase);
                _db.SaveChanges();
            }
            return personInDatabase;
        }

        public Person OnePerson(int id)
        {
            return _db.Persons.Find(id);
        }
    }
}
