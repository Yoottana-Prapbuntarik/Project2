using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 100)
            {
      
                Console.Write("Input x = ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Input y = ");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("Pow(x,y) = {0}", Math.Pow(x, y));
                Console.WriteLine("Max(x,y) = {0}", Math.Max(x, y));
                Console.WriteLine("Min(x,y) = {0}", Math.Min(x, y));
                Console.ReadLine();
            }
        }
    }
}
