using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using SaveLinks.DataLayer.Entities;
using SaveLinks.DataLayer.Repositories.PersonRepository;
using SaveLinks.Models.Person;

namespace SaveLinks.Services.PersonService
{
    public class PersonService : IPersonService
    {
        /*
         * Do logic here, like defaulting stuff, updating other stuff bla and return Models only
         * Turn Entities into Models using automapper
         * Only inject other repositories to grab data
         * Don't inject other Services
         */

        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;
        public PersonService(IMapper mapper, IPersonRepository personRepository)
        {
            _mapper = mapper;
            _personRepository = personRepository;
        }

        public IList<FakePerson> GetFakePersons()
        {
            var entities = _personRepository.GetAll();
            //IEnumerable doesent have .Add()
            entities = entities.ToList();
            //demonstrate automapper magic
            ((IList<Person>) entities).Add(new Person {Age = 21, LastName = "Urs", FirstName = "Rob"});
            ((IList<Person>) entities).Add(new Person {Age = 21, LastName = "Tom", FirstName = "Bea" });

            var models = entities.Select(x => _mapper.Map<FakePerson>(x)).ToList();
            models.Add(new FakePerson {Age = 21, FullName = "Ursu Robert Andrei"});
            models.Add(new FakePerson {Age = 22, FullName = "Toma Beatrice Ramona" });
            return models;
        }

        public IList<FakerPerson> GetFakerPersons()
        {
            var entities = _personRepository.GetAll();
            var models = entities.Select(x => _mapper.Map<FakerPerson>(x)).ToList();
            return models;
        }
    }
}