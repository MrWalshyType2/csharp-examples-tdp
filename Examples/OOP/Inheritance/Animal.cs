using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.OOP.Inheritance
{
    class Animal
    {
        // only non-private members of a class are inherited
        private string s; // not inherited

        protected string Name { get; set; } // inherited
        public int Age { get; set; } // inherited

        // constructors are not inherited
        public Animal()
        {
            Console.WriteLine("Not inherited");
        }

        // methods
        public void SomeBehaviour() // inherited
        {
            Console.WriteLine("Some behaviour");
        }

        // methods marked virtual can be overridden in child classes
        public virtual void OverridableMethod()
        {
            Console.WriteLine("I can be overridden in a derived type");
        }
    }
}
