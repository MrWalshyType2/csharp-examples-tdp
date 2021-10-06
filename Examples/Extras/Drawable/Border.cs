using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Extras.Drawable
{
    class Border : IDrawable
    {
        public void Draw()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("=");
                Console.SetCursorPosition(i, Console.WindowHeight - 1);
                Console.Write("=");
            }

            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("=");

                Console.SetCursorPosition(Console.WindowWidth - 1, i);
                Console.Write("=");
            }
        }
    }
}
