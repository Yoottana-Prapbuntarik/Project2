using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, x2, a, b, c ,const_x;
            Console.Write("Input a : ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Input b : ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Input c : ");
            c = double.Parse(Console.ReadLine());
                    //  b^2 - 4ac
            const_x = ((Math.Pow(b, 2)) - 4 * a * c);    
                    // sqrt b^2 - 4ac
            const_x = Math.Sqrt(const_x);
            
            x = (-b + const_x);
            x2 = (-b - const_x);
            x = (x / (2 * a));
            x2 = (x2 / (2 * a));
            Console.WriteLine("The answers of equation is {0} and {1}",x,x2);



            Console.ReadLine();
        }
    }
}
