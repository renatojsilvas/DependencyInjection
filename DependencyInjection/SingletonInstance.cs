using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class SingletonInstance : IDisposable
    {
        public SingletonInstance()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;

            Console.WriteLine($"Singleton instance with Guid {Id} has been created at {CreatedAt}");
        }

        public Guid Id { get; }

        public DateTime CreatedAt { get; }

        public override string ToString()
        {
            return $"Singleton - Guid {Id} ; Created at {CreatedAt}";
        }

        public void Dispose()
        {
            Console.WriteLine($"Singleton instance with Guid {Id} has been destroyed at {DateTime.Now}");
        }
    }
}
