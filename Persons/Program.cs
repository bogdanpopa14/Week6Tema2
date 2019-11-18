using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("ss");
            p1.Age = 2;
            Person p2 = new Person("aa");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.ReadLine();
        }
    }
}
