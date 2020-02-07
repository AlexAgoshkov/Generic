using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<ICar> cars = new CarCollection<ICar>();

            Car car = new Car("BMW", 1919);
            Car car1 = new Car("TT", 1991);
            SuperCar superCar = new SuperCar("SuperCar", 2019);

            cars.AddCar(car);
            cars.AddCar(car1);
            cars.AddCar(superCar);

            foreach (var item in cars.GetList())
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();

            Console.WriteLine(cars[1].Name);
            Console.WriteLine(cars.Count);

            cars.Clear();

            cars.AddCar(car);
            cars.AddCar(car1);
            cars.AddCar(superCar);

            foreach (var item in cars.GetList())
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();

            Console.WriteLine(cars[1].Name);
            Console.WriteLine(cars.Count);


            Console.ReadKey();
        }
    }
}
