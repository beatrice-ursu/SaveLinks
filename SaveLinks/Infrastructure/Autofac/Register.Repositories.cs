using Autofac;
using SaveLinks.DataLayer.Repositories.PersonRepository;

namespace SaveLinks.Infrastructure.Autofac
{
    public static partial class AutofacBootstrapper
    {
        private static void RegisterRepositories(this ContainerBuilder builder)
        {
            //register repositories
            builder.RegisterType<PersonRepository>().As<IPersonRepository>();
        }
    }
}