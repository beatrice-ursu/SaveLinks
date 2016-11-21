using SaveLinks.DataLayer.Entities;
using SaveLinks.DataLayer.Repositories.GenericRepository;

namespace SaveLinks.DataLayer.Repositories.PersonRepository
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
        //Do stuff Database ONLY related
    }
}