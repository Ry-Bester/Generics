using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<int> obj1 = new Employee<int>();
            obj1.Things = new List<int>();
            obj1.Things.Add(4);
            obj1.Things.Add(6);
            obj1.Things.Add(8);
            obj1.Things.Add(10);
            Employee<string> obj2 = new Employee<string>();
            obj2.Things = new List<string>();
            obj2.Things.Add("Bob");
            obj2.Things.Add("Joe");
            obj2.Things.Add("Bill");
            obj2.Things.Add("Ryan");

           foreach(var element in obj1.Things)
            {
                Console.WriteLine(element);
            }
            foreach (var element in obj2.Things)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}
