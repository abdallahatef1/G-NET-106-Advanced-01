using System;
using System.Collections.Generic;
using System.Text;

namespace advanced1
{
    internal class Pair<TKey, TValue>
    {
        #region Q3:What are multiple type parameters? Write Pair<TKey, TValue>.
        //A generic type can declare several type parameters, separated by commas.
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public Pair(TKey key, TValue value) { Key = key; Value = value; }
        #endregion
    }
}
