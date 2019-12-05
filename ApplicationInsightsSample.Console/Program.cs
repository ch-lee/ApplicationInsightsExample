using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationInsightsSample.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();

            Startup startup = new Startup();
            startup.ConfigureServices(services);

            IServiceProvider serviceProvider = services.BuildServiceProvider();
            var myService = serviceProvider.GetService<IMyService>();

            System.Console.WriteLine("App insights setup!");

            myService.WriteSomethingToLog();

        }
    }
}
