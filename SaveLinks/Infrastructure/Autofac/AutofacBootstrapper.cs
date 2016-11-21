using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using SaveLinks.Infrastructure.Automapper;

namespace SaveLinks.Infrastructure.Autofac
{
    public static partial class AutofacBootstrapper
    {
        public static ContainerBuilder Configure()
        {
            var builder = new ContainerBuilder();

            //Config
            builder.RegisterControllers(typeof(SaveLinksWeb).Assembly);
            
            //Core
            builder.Register(x => AutomapperBootstrapper.GetConfiguration()).SingleInstance().AutoActivate().AsSelf();
            builder.Register(x => x.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>();

            //Repositories
            builder.RegisterRepositories();

            //Services
            builder.RegisterServices();

            return builder;
        }
    }
}