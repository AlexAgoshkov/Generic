using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class CarCollection<T> where T : class,ICar
    {
        public CarCollection()
        {
            _item = new T[8];
        }

        public int Count { get; private set; }

        private T[] _item;

        public void AddCar(T car)
        {
            if (!IsEmptyCell())
            {
                ChangeCapactiy();
            }
            for (int i = 0; i < _item.Length; i++)
            {
                if (_item[i] == null)
                {
                    _item[i] = car;
                    Count++;
                    break;
                }
            }

        }

        public T[] GetList()
        {
            RemoveDefault();
            return _item;
        }

        public T this[int index]
        {
            get
            {
                return _item[index];
            }
            private set
            {
                _item[index] = value;
            }
        }

        private void RemoveDefault()
        {
            T[] newArr = new T[Count];

            for (int i = 0; i < _item.Length - 1; i++)
            {
                if (_item[i] == null)
                {
                    var a = _item[i];
                    _item[i] = _item[i + 1];
                    _item[i + 1] = a;
                }
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = _item[i];
            }

            _item = newArr;
        }

        private void ChangeCapactiy()
        {
            T[] newArr = _item;
            _item = new T[newArr.Length * 2];

            for (int i = 0; i < newArr.Length; i++)
            {
                _item[i] = newArr[i];
            }
        }

        private bool IsEmptyCell()
        {
            bool result = false;

            for (int i = 0; i < _item.Length; i++)
            {
                if (_item[i] == null)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }
    }
}
