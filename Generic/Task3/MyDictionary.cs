﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MyDictionary<TKey, TValue>
    {
        public MyKeyPair<TKey, TValue>[] _myKeyPairs = new MyKeyPair<TKey, TValue>[5];

        public int Count { get; private set; }

        public void Add(TKey key, TValue value)
        {
            for (int i = 0; i < _myKeyPairs.Length; i++)
            {
                if (Count >= _myKeyPairs.Length)
                {
                    ChangeCapactiy();
                }

                if (_myKeyPairs[i] == null)
                {
                    _myKeyPairs[i] = new MyKeyPair<TKey, TValue>() { Key = key };
                    _myKeyPairs[i].Values.Add(value);
                    Count++;
                    break;
                }
                else if(IsKey(key))
                {
                    _myKeyPairs[i].Values.Add(value);
                    break;
                }
            }
        }

        private void ChangeCapactiy()
        {
            MyKeyPair<TKey, TValue>[] newArr = _myKeyPairs;

            _myKeyPairs = new MyKeyPair<TKey, TValue>[newArr.Length * 2];

            for (int i = 0; i < newArr.Length; i++)
            {
                _myKeyPairs[i] = newArr[i];
            }
        }

        public bool IsKey(TKey key)
        {
            bool result = false;

            foreach (var item in _myKeyPairs)
            {
                if (item != null && item.Key.Equals(key))
                {
                    result = true;
                }
            }

            return result;
        }

        public void GetList()
        {
            foreach (var item in _myKeyPairs)
            {
                if (item != null)
                {
                    Console.WriteLine($"   {item.Key}");
                    foreach (var val in item.Values)
                    {
                       Console.WriteLine(val);
                    }
                }
            }
        }

        public MyKeyPair<TKey, TValue>this[int index]
        {
            get
            {
                return _myKeyPairs[index];
            }
            set
            {
                _myKeyPairs[index] = value;
            }
        }

        
    }    
}
