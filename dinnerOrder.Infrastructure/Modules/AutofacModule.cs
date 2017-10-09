using Autofac;
using dinnerOrder.Infrastructure.Services;
using dinnerOrder.Infrastructure.Repositories;
using AutoMapper;
using dinnerOrder.Infrastructure.Entities;
using dinnerOrder.Infrastructure.ViewModels;

namespace dinnerOrder.Infrastructure.Modules
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigureServices(builder);
            ConfigureRepositories(builder);
            ConfigureInfrastructure(builder);
        }

        private void ConfigureServices(ContainerBuilder builder)
        {
            builder.RegisterType<RestaurantService>().As<IRestaurantService>().InstancePerDependency();
        }

        private void ConfigureRepositories(ContainerBuilder builder)
        {
            builder.RegisterType<RestaurantRepository>().As<IRestaurantRepository>().InstancePerDependency();
        }

        public void ConfigureInfrastructure(ContainerBuilder builder)
        {
            builder.Register(c => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Restaurant, RestaurantViewModel>();
            })).AsSelf().SingleInstance();

            builder.Register(
                c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve))
                .As<IMapper>()
                .InstancePerLifetimeScope();
        }
    }
}
