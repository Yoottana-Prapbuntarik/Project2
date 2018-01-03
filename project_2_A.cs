using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double Fahrenheit, Celsius;
            Console.Write("Input a temperature in degree Celsius :");
            Celsius = double.Parse(Console.ReadLine());
            Fahrenheit = (1.8 * Celsius + 32);
            Console.WriteLine("{0} degrees Celsius is equivalent to {1} degrees Fahrenheit ",Celsius,Fahrenheit);
            Console.ReadLine();

        }
    }
}
