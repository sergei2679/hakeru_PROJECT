using System.Collections.Generic;

namespace home_20200402_Collection_Queue
{
    interface IList<T> : IEnumerable<T>
    {
        void Add(T x);
        void Add(int index, T x);
        T Get(int index);
        void Set(int index, T x);
        void Remove(int index);
        int Count();
        int IndexOf(T x);
        T[] ToArray();
        void Clear();

    }
}
