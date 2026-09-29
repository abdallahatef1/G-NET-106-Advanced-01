using System;
using System.Collections.Generic;
using System.Text;

namespace advanced1
{
    internal class Cache<TKey, TValue>
    {
        private class Entry
        {
            public TValue Value;
            public DateTime Expiry;
        }
        private Dictionary<TKey, Entry> store = new Dictionary<TKey, Entry>();
        private TimeSpan defaultTtl;   

        public Cache(TimeSpan ttl)
        {
            defaultTtl = ttl;
        }
        public void Add(TKey key, TValue value)
        {
            Entry e = new Entry();
            e.Value = value;
            e.Expiry = DateTime.Now + defaultTtl;
            store[key] = e;
        }

        public TValue Get(TKey key)
        {
            if (Contains(key))
                return store[key].Value;

            return default(TValue);
        }
        public bool Remove(TKey key)
        {
            return store.Remove(key);
        }
        public bool Contains(TKey key)
        {
            if (!store.ContainsKey(key))
                return false;

            if (store[key].Expiry <= DateTime.Now)   
            {
                store.Remove(key);
                return false;
            }

            return true;
        }
    }
}
