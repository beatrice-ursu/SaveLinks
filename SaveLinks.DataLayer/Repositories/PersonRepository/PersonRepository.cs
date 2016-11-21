using SaveLinks.DataLayer.Entities;
using SaveLinks.DataLayer.Repositories.GenericRepository;

namespace SaveLinks.DataLayer.Repositories.PersonRepository
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        //Do stuff Database ONLY related
    }
}