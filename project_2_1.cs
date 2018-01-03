using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.0, y = 2.0;
            int a = 10, b = 2;

            Console.WriteLine(x + a * b);
            Console.WriteLine( b * a / b);
            Console.WriteLine( y / x % b);
            Console.WriteLine(a - y % x);
            Console.WriteLine( ++y % x - 2);
            Console.WriteLine(+ a - b % a % b);
            //Console.WriteLine(x / y++b);
            Console.WriteLine(x / y * b++);
            Console.WriteLine(x + y - x * y % y);
            Console.WriteLine((a + b) * (a - b) % x);
            Console.ReadLine();
        }
    }
}
