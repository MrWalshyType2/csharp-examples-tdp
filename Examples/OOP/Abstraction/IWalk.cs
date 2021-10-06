using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.OOP.Abstraction
{
    interface IWalk
    {
        // interface members are implicitly public and virtual, they just require an implementation in a derived type
        // - interfaces describe a can-do/implement relationship
        // - abstraction means the implementation details are hidden from the caller
        void Walk();
    }
}
