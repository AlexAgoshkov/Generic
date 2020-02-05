using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> myClass = new MyClass<int>();
            myClass.FacrotyMethod(20);
            Console.WriteLine(myClass.Value);

            MyClass<string> myClass2 = new MyClass<string>();
            myClass2.FacrotyMethod("Hello");
            Console.WriteLine(myClass2.Value);

            MyClass<double> myClass3 = new MyClass<double>();
            myClass3.FacrotyMethod(20.5);
            Console.WriteLine(myClass3.Value);

            Console.ReadKey();
        }
    }
}
