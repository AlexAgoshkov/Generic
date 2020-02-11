using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class MyArrayList 
    {
        private object[] _array = new object[8];

        public int Count { get; private set; }

        public void Add(object item)
        {
           
            if (Count >= _array.Length)
            {
                ChangeCapactiy();
            }
            _array[Count] = item;
            Count++;
        }

        public object[] GetList()
        {
            RemoveDefault();
            return _array;
        }

        public void Remove(object item)
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

        public object IndexOf(int index)
        {
            object element = null;

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
            _array = new object[8];
            Count = 0;
        }

        private void ChangeCapactiy()
        {
            object[] newArr = _array;
            _array = new object[newArr.Length * 2];

            for (int i = 0; i < newArr.Length; i++)
            {
                _array[i] = newArr[i];
            }
        }

        private void RemoveDefault()
        {
            object[] newArr = new object[Count];

            for (int i = 0; i < _array.Length - 1; i++)
            {
                if (_array[i] == null)
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


