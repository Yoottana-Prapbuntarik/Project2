using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            double x, y, z;
           
                Console.Write("Input x : ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Input y : ");
                y = int.Parse(Console.ReadLine());

                z = ((x * x) + (y * y));

                z = Math.Sqrt(z);

                Console.WriteLine("The length of z is {0}", z);
                Console.WriteLine("The length of perimeter is {0}", x + y + z);
            
            Console.ReadLine();
        }
    }
}
