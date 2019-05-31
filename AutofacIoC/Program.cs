using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacIoC
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = BuildContainer();
            var appService = container.Resolve<IAppService>();
            appService.ShowAllContact();
            Console.ReadLine();
        }

        static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ContactRepo>().As<IContactRepo>();
            builder.RegisterType<AppService>().As<IAppService>();
            return builder.Build();
        }
    }
}
