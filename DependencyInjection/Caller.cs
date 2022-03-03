using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Caller
    {
        private readonly SingletonInstance singleton;
        private readonly ScopedInstance scoped;
        private readonly TransientInstance transient;

        public Caller(SingletonInstance singleton, ScopedInstance scoped, TransientInstance transient)
        {
            this.singleton = singleton;
            this.scoped = scoped;
            this.transient = transient;
        }

        public void Invoke()
        {
            Console.WriteLine(singleton);
            Console.WriteLine(transient);
            Console.WriteLine(scoped);
        }
    }
}
