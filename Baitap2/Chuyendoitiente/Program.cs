using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuyendoitiente
{
    class Program
    {
        static void Main(string[] args)
        {
            int rate = 23000;
            int usd;
            Console.WriteLine("Input your amount of usd to convert: ");
            usd = int.Parse(Console.ReadLine());
            int result = usd * rate;
            Console.WriteLine("Result in vnd: " + result);
        }
    }
}
