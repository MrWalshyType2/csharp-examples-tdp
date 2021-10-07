using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Examples.ConsoleAppExample.Data.Repositories;
using Examples.ConsoleAppExample.Data.Model;

namespace Examples.Extensions
{
    // extension methods must be in a static class
    // - the extension methods should also be static
    static class ExtensionMethods
    {

        // we must specify the type as a parameter that the extension
        // method applies to
        // - it must be preceded by the `this` keyword
        // - cannot override methods that already exist on the string class
        public static void Write(this string s)
        {
            Console.WriteLine(s);
        }

        public static void ReadById(this ICrdRepository<Item, int> s, int id)
        {
            Console.WriteLine($"reading by id {id}");
        }
    }
}
