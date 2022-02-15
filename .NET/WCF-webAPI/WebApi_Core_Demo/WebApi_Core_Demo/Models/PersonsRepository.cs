using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Core_Demo.Models
{
    public class PersonsRepository : IPersonsInterface
    {
        List<Person> personer = new List<Person>
        {
            new Person{ Id = 1, FirstName = "Ole", LastName="Olsen", City="Valby" },
             new Person{ Id = 2, FirstName = "Jens", LastName="Jensen", City="Viby" },
              new Person{ Id = 3, FirstName = "Per", LastName="Persen", City="Rødby" },
               new Person{ Id = 4, FirstName = "Peter", LastName="Petersen", City="Tårnby" },
                new Person{ Id = 5, FirstName = "Ida", LastName="Olsen", City="Brøndby" },
                 new Person{ Id = 6, FirstName = "Maria", LastName="Pedersen", City="Nyby" }
        };

        public Person AddPerson(Person newPerson)
        {
            personer.Add(newPerson);
            return newPerson;
        }

        public List<Person> AllPersons()
        {
            return personer;
        }

        public Person OnePerson(int id)
        {
            Person person = personer.FirstOrDefault(p => p.Id == id);
            return person;
        }
        public void DeletePerson(Person poorGuy)
        {
            personer.Remove(poorGuy);
        }

        public Person EditPerson(Person personToBeEdited)
        {
            Person personInList = OnePerson(personToBeEdited.Id);
            personInList.Id = personToBeEdited.Id;
            personInList.FirstName = personToBeEdited.FirstName;
            personInList.LastName = personToBeEdited.LastName;
            personInList.City = personToBeEdited.City;

            return personInList;
        }

      
    }
}
