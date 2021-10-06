using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Extras.Drawable
{
    interface IDrawer
    {
        public void Draw(IEnumerable<IDrawable> drawables);
    }
}
