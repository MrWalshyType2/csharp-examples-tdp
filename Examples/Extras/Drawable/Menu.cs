using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Extras.Drawable
{
    class Menu : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("=== Menu ===");
            Console.WriteLine("1. Something");
            Console.WriteLine("2. Quit");
            Console.WriteLine("=== ==== ===");
        }
    }
}
