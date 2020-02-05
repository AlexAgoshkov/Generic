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
            Car car2 = new Car("LA", 1992);
            Car car3 = new Car("AU", 1993);
            Car car4 = new Car("SS", 1994);
            Car car5 = new Car("LM", 1995);
            Car car6 = new Car("VW", 1996);
            Car car7 = new Car("MR", 19911);
            SuperCar superCar = new SuperCar("SuperCar", 2019);

            cars.AddCar(car);
            cars.AddCar(car1);
            cars.AddCar(car2);
            cars.AddCar(car3);
            cars.AddCar(car4);
            cars.AddCar(car5);
            cars.AddCar(car6);
            cars.AddCar(car7);
            cars.AddCar(car1);
            cars.AddCar(car);
            cars.AddCar(superCar);

            foreach (var item in cars.GetList())
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();

            Console.WriteLine(cars[1].Name);

            Console.ReadKey();
        }
    }
}
