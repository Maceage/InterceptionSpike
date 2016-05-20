using Autofac;
using Autofac.Extras.DynamicProxy2;
using InterceptionSpike.Services.Interfaces;

namespace InterceptionSpike
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<InterceptorDependency>()
                .As<IInterceptorDependency>();

            builder.RegisterType<ServiceInterceptor>();

            builder.RegisterAssemblyTypes(typeof(IService).Assembly)
                ////.Where(t => t.GetInterfaces().Contains(typeof(IService)))
                .As<IService>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(ServiceInterceptor));
        }
    }
}