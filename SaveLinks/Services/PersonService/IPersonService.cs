using System.Collections.Generic;
using SaveLinks.Models.Person;

namespace SaveLinks.Services.PersonService
{
    public interface IPersonService
    {
        //Do logic here, like defaulting stuff, updating other stuff bla and return Models only
        IList<FakePerson> GetFakePersons();
        IList<FakerPerson> GetFakerPersons();
    }
}