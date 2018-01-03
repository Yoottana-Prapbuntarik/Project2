using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            char c;
            Console.Write("Please input something : ");
            x = Console.Read();
            Console.WriteLine(x);
            c = Convert.ToChar(x);
            Console.WriteLine(c);
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
    