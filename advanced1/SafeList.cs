using System;
using System.Collections.Generic;
using System.Text;

namespace advanced1
{
    internal class SafeList<T>
    {
        private List<T> list = new List<T>();

        public void Add(T item)
        {
            list.Add(item);
        }

        public T Get(int index)
        {
            if (index >= 0 && index < list.Count)
                return list[index];      // valid index

            return default(T);           // invalid index
        }
    }
}
