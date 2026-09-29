using System;
using System.Collections.Generic;
using System.Text;

namespace advanced1
{
    internal class ClassWrapper<T> where T : class
    {
        //Q8
        // The class constraint is used with generics to specify that the type T must be a reference type
        public T  Item;
    }
}
