using Autofac;
using MySeries.Core.Interfaces.UseCases;
using MySeries.Core.UseCases;

namespace MySeries.Core
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CreateSerieUseCase>().As<ICreateSerieUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<ListSerieUseCase>().As<IListSerieUseCase>().InstancePerLifetimeScope();
            //builder.RegisterType<LoginUseCase>().As<ILoginUseCase>().InstancePerLifetimeScope();
        }
    }
}