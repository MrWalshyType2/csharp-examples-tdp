using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Extras.Drawable
{
    class MyDrawer : IDrawer
    {
        public void Draw(IEnumerable<IDrawable> drawables)
        {
            Console.Clear();

            foreach (var drawable in drawables)
            {
                drawable.Draw();
            }
        }
    }
}
