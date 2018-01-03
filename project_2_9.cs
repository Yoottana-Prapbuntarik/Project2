using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int Divided ,Divisor,Quotient , remainder;
            Console.Write("Input Divided : ");
            Divided = int.Parse(Console.ReadLine());
            Console.Write("Input Divisor : ");
            Divisor = int.Parse(Console.ReadLine());
            Quotient = (Divided / Divisor);
            remainder = (Divided % Divisor);
            Console.Write("Quotient Of {0}/{1} is : {2} and remainder is : {3}", Divided,Divisor,Quotient,remainder);
            Console.ReadLine();

        }
    }
}
