using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            IMyList<int> myList = new MyList<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Remove(4);
            myList.Remove(2);
            myList.Remove(1);

            foreach (var item in myList.GetList())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(myList.Count);

            Console.WriteLine(myList.IndexOf(2));

            Console.WriteLine();
            Console.WriteLine();

            myList.ClearList();

            myList.Add(7);
            myList.Add(8);
            myList.Add(9);

            foreach (var item in myList.GetArray())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    public static class ListExtension
    {
        public static T[] GetArray<T>(this IMyList<T> list)
        {
            return list.GetList();
        }
    }
}
