using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.OOP.Abstraction
{

    class Dog : Animal
    {
        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override void OverridableMethod()
        {
            base.OverridableMethod(); // calling original (not necessary but can be useful)
            Console.WriteLine("My new stuff for this method");
        }

        public override void Walk()
        {
            Console.WriteLine("Wags tail and runs");
        }
    }
}
