using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.ConsoleAppExample.Data.Model
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Item[ID={ID}, Name={Name}]";
        }
    }
}
