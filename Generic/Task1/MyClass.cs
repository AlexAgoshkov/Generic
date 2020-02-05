using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MyClass<T>
    {
        public void FacrotyMethod(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
    }
}
