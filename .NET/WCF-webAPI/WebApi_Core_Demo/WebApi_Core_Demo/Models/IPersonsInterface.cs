using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Core_Demo.Models
{
    public interface IPersonsInterface
    {
        List<Person> AllPersons(); // get   all
        Person OnePerson(int id); // get (id)
        Person AddPerson(Person newPerson);  // Post
        Person EditPerson(Person personToBeEdited); // patch or put
        void DeletePerson(Person poorGuy);  // delete
    }
}
