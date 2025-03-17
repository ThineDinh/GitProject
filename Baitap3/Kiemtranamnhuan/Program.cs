using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtranamnhuan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the year: ");
            int year = int.Parse(Console.ReadLine());

            if (IsLeapYear(year))
                Console.WriteLine(year + " is a leap year!");
            else
                Console.WriteLine(year + " is not a leap year!");
        }

        static bool IsLeapYear(int a)
        {
            return (a % 4 == 0 && a % 100 != 0) || (a % 400 == 0);
        }
    }
}
