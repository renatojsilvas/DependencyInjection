using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<SingletonInstance>();
            serviceCollection.AddTransient<TransientInstance>();
            serviceCollection.AddScoped<ScopedInstance>();
            serviceCollection.AddTransient<Caller>();

            var serviceProvider = serviceCollection.BuildServiceProvider();            

            Console.WriteLine();
            Console.WriteLine("Request 1");

            var caller1 = serviceProvider.GetService<Caller>();
            caller1.Invoke();

            for (int i = 2; i < 7; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Request {i} - Same scope");

                var caller2 = serviceProvider.GetService<Caller>();
                caller2.Invoke();
            }            

            using (var scope = serviceProvider.CreateScope())
            {
                for (int i = 7; i < 12; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Request {i} - Another scope");

                    var caller3 = scope.ServiceProvider.GetService<Caller>();
                    caller3.Invoke();
                }
            }
        }              
    }
}
