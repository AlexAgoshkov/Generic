using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Car : ICar
    {
        public Car(string name, int year)
        {
            Name = name;
            Year = year;
        }

        public string Name { get; private set; }

        public int Year { get; private set; }
    }
}
