using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class MyKeyPair<T, V>
    {
        public MyKeyPair()
        {
            Values = new List<V>();

        }

        public void Add(T key, V value)
        {
            Key = key;
            Values.Add(value);
        }

        public List<V> Values { get; set; }

        public T Key { get; set; }
    }
}
