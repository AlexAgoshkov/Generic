using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MyList<T> : IMyList<T>
    {
        private T[] _array = new T[8];

        public int Count { get; private set; }

        public void Add(T item)
        {
            if (Count >= _array.Length)
            {
                ChangeCapactiy();

            }
            _array[Count] = item;
            Count++;
        }

        public T[] GetList()
        {
            RemoveDefault();
            return _array;
        }

        public void Remove(T item)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(item))
                {
                    _array[i] = default;
                    Count--;
                    break;
                }
            }
            RemoveDefault();
        }

        public T IndexOf(int index)
        {
            T element = default;

            for (int i = 0; i < _array.Length; i++)
            {
                if (i == index)
                {
                    element = _array[i];
                    break;
                }
            }

            return element;
        }

        public void ClearList()
        {
            _array = new T[8];
            Count = 0;
        }

        private void ChangeCapactiy()
        {
            T[] newArr = _array;
            _array = new T[newArr.Length * 2];

            for (int i = 0; i < newArr.Length; i++)
            {
                _array[i] = newArr[i];
            }
        }

        private void RemoveDefault()
        {
            T[] newArr = new T[Count];

            for (int i = 0; i < _array.Length - 1; i++)
            {
                if (_array[i].Equals(default(T)))
                {
                    var a = _array[i];
                    _array[i] = _array[i + 1];
                    _array[i + 1] = a;
                }
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = _array[i];
            }

            _array = newArr;
        }
    }
}
