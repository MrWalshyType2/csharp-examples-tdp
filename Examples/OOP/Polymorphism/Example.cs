using Examples.OOP.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.OOP.Polymorphism
{
    class Example
    {
        // Using the classes and interfaces from the Abstraction namespace

        // Polymorphism allows for subtypes to be put in a variable of their parent type
        // - A Dog is-a Animal
        public Animal a = new Dog("Fred", 3);
        //public Animal a2 = new Animal(); // illegal, cannot instantiate abstract classes

        // This also works with interfaces
        // - A Dog can-do IWalk
        public IWalk walkableAnimal = new Dog("Bob", 17);

        public void UsePolymorphicBehaviour()
        {
            a.Walk(); // Calls Dog.Walk() on the dog object inside the Animal variable
            walkableAnimal.Walk(); // same as above
        }
    }
}
