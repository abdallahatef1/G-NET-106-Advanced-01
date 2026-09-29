using System;
using System.Collections.Generic;
using System.Text;

namespace advanced1
{
    //q12
    internal class Factory<T> where T : Animal, IPet, new()
    {
        public T Build()
        {
            return new T();
        }
    }
}
