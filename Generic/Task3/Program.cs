using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            
            myDictionary.Add("Hello", "Worldss");
            myDictionary.Add("Hello21312", "MIPsasdasss");
            myDictionary.Add("Worldddd", "Myssadassa");
            myDictionary.Add("Hello", "Test");
            myDictionary.Add("Hello", "Two");
            myDictionary.GetList();

            var a = myDictionary._myKeyPairs[0].Values;

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
