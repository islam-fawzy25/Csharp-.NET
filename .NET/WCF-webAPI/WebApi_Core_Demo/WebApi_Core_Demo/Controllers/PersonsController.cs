using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Core_Demo.Models;

namespace WebApi_Core_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        //List<Person> personer = new List<Person>
        //{
        //    new Person{ Id = 1, FirstName = "Ole", LastName="Olsen", City="Valby" },
        //     new Person{ Id = 2, FirstName = "Jens", LastName="Jensen", City="Viby" },
        //      new Person{ Id = 3, FirstName = "Per", LastName="Persen", City="Rødby" },
        //       new Person{ Id = 4, FirstName = "Peter", LastName="Petersen", City="Tårnby" },
        //        new Person{ Id = 5, FirstName = "Ida", LastName="Olsen", City="Brøndby" },
        //         new Person{ Id = 6, FirstName = "Maria", LastName="Pedersen", City="Nyby" }
        //};

        private readonly IPersonsInterface _data;
        public PersonsController(IPersonsInterface data)
        {
            _data = data;
        }

        [HttpGet] // api/persons
        public ActionResult<IEnumerable<Person>> GetAllPersons()
        {
            //return personer;
            return _data.AllPersons();
        }
        [HttpGet("{id}")] // api/person/id
        public ActionResult<Person> GetOnePerson(int id)
        {
            //Person person = personer.FirstOrDefault(p => p.Id == id);
            Person person = _data.OnePerson(id);
            if (person !=null)
            {
                return person;
            }
            return NotFound($"person with id = {id} was not found");
        }
        [HttpPost]
        public ActionResult<Person> AddPerson(Person newPerson)
        {
           return  _data.AddPerson(newPerson);  
        }

        [HttpDelete("{id}")]
        public ActionResult<Person> DeletePerson(int id)
        {
            Person poorGuy = _data.OnePerson(id);
            if (poorGuy != null)
            {
                _data.DeletePerson(poorGuy);
                return Ok();
            }
            return NotFound($"person with id = {id} was not found");
        }
        //[HttpPut("{id}")]
        //public ActionResult<Person> EditPerson(int id, Person personCorrected)
        //{
        //    Person personInList = _data.OnePerson(personCorrected.Id);
        //    if (personInList != null)
        //    {
        //        //personCorrected.Id = personInList.Id;
        //        _data.EditPerson(personCorrected);
        //        return Ok();
        //    }
        //    return NotFound($"person with id = {id} was not found");
        //}
        /* Edit: */

        [HttpPut, HttpPatch]
        public ActionResult<Person> EditPerson(Person personToBeEdited)
        {
            Person personInList = _data.OnePerson(personToBeEdited.Id);
            if (personInList != null)
            {
                _data.EditPerson(personToBeEdited);
                return Ok();
            }
            return NotFound($"Person with id = {personToBeEdited.Id} was not found");
        }

    }
}
