using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class TransientInstance : IDisposable
    {
        public TransientInstance()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;

            Console.WriteLine($"Transient instance with Guid {Id} has been created at {CreatedAt}");
        }

        public Guid Id { get; }

        public DateTime CreatedAt { get; }

        public override string ToString()
        {
            return $"Transient - Guid {Id} ; Created at {CreatedAt}";
        }

        public void Dispose()
        {
            Console.WriteLine($"Transient instance with Guid {Id} has been destroyed at {DateTime.Now}");
        }
    }
}
