using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();

            myDictionary.Add("Hello", "World");
            myDictionary.Add("MyTest", "Number");
            myDictionary.Add("Something", "Allo");
            myDictionary.Add("Hello", "Testing");
            myDictionary.Add("Hello", "OneTwo");
            myDictionary.RemoveFromKey("Hello", "Testing");
            myDictionary.RemoveKey("MyTest");
            myDictionary.GetList();

           var a = myDictionary._myKeyPairs[2].Values;

            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine(myDictionary.Count);
            Console.ReadKey();
        }
    }
}
