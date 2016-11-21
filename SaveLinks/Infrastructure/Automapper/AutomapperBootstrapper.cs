using AutoMapper;
using SaveLinks.Infrastructure.Automapper.Profiles;

namespace SaveLinks.Infrastructure.Automapper
{
    public class AutomapperBootstrapper
    {
        public static MapperConfiguration GetConfiguration()
        {
            return new MapperConfiguration(cfg =>
            {
                //profiles
                cfg.AddProfile<PersonProfile>();
            });
        }
    }
}