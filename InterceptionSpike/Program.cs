using System.Collections.Generic;
using Autofac;
using InterceptionSpike.Services.Interfaces;

namespace InterceptionSpike
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder  = new ContainerBuilder();

            builder.RegisterModule<ServicesModule>();

            var container = builder.Build();

            var services = container.Resolve<IEnumerable<IService>>();

            foreach (var service in services)
            {
                service.DoSomething();
            }
        }
    }
}
