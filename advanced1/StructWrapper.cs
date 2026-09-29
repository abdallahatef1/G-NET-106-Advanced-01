using System;
using System.Collections.Generic;
using System.Text;

namespace advanced1
{
    //q7
    // The struct constraint is used with generics to specify that the type T must be a value type
    internal class StructWrapper<T> where T : struct
    {
        public T Value;


    }
}
