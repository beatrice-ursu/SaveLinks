using AutoMapper;
using SaveLinks.DataLayer.Entities;
using SaveLinks.Models.Person;

namespace SaveLinks.Infrastructure.Automapper.Profiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, FakePerson>()
                .ForMember(dest => dest.FullName, a => a.MapFrom(src => src.LastName + " " + src.FirstName));
            CreateMap<Person, FakerPerson>();

            CreateMap<FakerPerson, Person>();
            CreateMap<FakePerson, Person>();
        }
    }
}