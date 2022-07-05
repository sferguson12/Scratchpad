using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Scratchpad.Library;

namespace Scratchpad.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var serviceProvider = new ServiceCollection()
                .AddLogging(builder => builder.AddConsole().AddFilter(l => l >= LogLevel.Debug))
                .ConfigureLibrary()
                .AddSingleton<MyController, MyController>()
                .BuildServiceProvider();

            var logger = serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();

            var controller = serviceProvider.GetService<MyController>();
            controller.DoSomething();
        }
    }
}
