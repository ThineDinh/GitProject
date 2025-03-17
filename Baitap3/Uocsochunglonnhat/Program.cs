using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uocsochunglonnhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number A: ");
            bool success = int.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("Enter number B: ");
            success = int.TryParse(Console.ReadLine(), out int b);
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else b = b - a;
            }
            Console.WriteLine("Result: " + a);
        }
    }
}
