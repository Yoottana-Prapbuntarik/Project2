using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input = ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Abs(x) = {0}", Math.Abs(x));
            Console.WriteLine("Ceiling(x) = {0}", Math.Ceiling(x));
            Console.WriteLine("Floor(x) = {0}", Math.Floor(x));
            Console.WriteLine("Round(x) = {0}", Math.Round(x));
            Console.ReadLine();
        }
    }
}
