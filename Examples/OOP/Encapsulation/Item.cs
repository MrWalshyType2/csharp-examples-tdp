using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.OOP.Encapsulation
{
    class Item
    {
        // Encapsulation concerns bundling cohesive state and behaviour and restricting access

        public int ID { get; set; } // Auto implemented property

        private string name; // field

        // setter method for the name field
        public void SetName(string name)
        {
            this.name = name;
        }

        // getter method for the name field
        public string GetName()
        {
            return name;
        }
    }
}
