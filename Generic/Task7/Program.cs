using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList arrayList = new MyArrayList();
          
            arrayList.Add(4);
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Remove(2);
            var elemByIndex = arrayList.IndexOf(2);
            Console.WriteLine(elemByIndex);
            Console.WriteLine();
            foreach (var item in arrayList.GetList())
            {
                Console.WriteLine(item);
                
            }



            Console.ReadKey();
        }
    }
}
