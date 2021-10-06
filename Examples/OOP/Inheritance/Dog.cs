using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.OOP.Inheritance
{
    // The colon separator is used to specify inheritance
    // - Dog inherits from the class Animal (Dog is-a Animal)
    // - Only one class can be inherited from
    class Dog : Animal
    {
        public Dog(string name, int age)
        {
            // setting inherited fields
            Name = name;
            Age = age;
        }

        // overriding inherited virtual method
        public override void OverridableMethod()
        {
            base.OverridableMethod(); // calling original (not necessary but can be useful)
            Console.WriteLine("My new stuff for this method");
        }
    }
}
