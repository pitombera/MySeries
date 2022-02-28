using Autofac;
using MySeries.Core.Interfaces.Repositories;
using MySeries.Infrastructure.Data.EntityFramework.Repositories;

namespace MySeries.Infrastructure
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SerieRepository>().As<ISerieRepository>().InstancePerLifetimeScope();
            //builder.RegisterType<JwtFactory>().As<IJwtFactory>().SingleInstance();
        }
    }
}