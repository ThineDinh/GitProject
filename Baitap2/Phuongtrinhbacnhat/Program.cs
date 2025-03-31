using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phuongtrinhbacnhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");
            Console.WriteLine("Input a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input b: ");
            double b = double.Parse(Console.ReadLine());
            if (a != 0)
            {
                double solution = -b / a;
                Console.Write("The solution is: {0}!", solution);
            }
            else
            {
                if (b == 0)
                {
                    Console.Write("The solution is all x!");
                }
                else
                {
                    Console.Write("No solution!");
                }
            }
        }
    }
}
