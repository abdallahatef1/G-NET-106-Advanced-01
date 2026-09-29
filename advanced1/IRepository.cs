using System;
using System.Collections.Generic;
using System.Text;

namespace advanced1
{
    //q6
    //A Generic Interface is an interface that uses a type parameter <T>, allowing the same interface to work with different data types.
    internal interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        T GetById(int id);
        List<T> GetAll();

    }
}
