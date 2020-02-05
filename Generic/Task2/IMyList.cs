using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface IMyList<T>
    {
        void Add(T item);

        void Remove(T item);

        T[] GetList();

        int Count { get; }

        T IndexOf(int index);

        void ClearList();
    }
}
