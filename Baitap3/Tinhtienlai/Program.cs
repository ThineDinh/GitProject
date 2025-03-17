using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinhtienlai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input original money: ");
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine("Input months: ");
            double month = int.Parse(Console.ReadLine());
            Console.WriteLine("Input annual interest rate in percentage: ");
            double rate = double.Parse(Console.ReadLine());
            double result = 0;
            for (int i = 0; i <= month; i++)
            {
                result += money * (rate / 100) / 12;
            }
            Console.WriteLine("The result is :" + result);
        }
    }
}
