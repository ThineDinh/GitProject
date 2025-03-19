using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinhtongtrongmang
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int Total = 0;
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 10);
                Console.Write(numbers[i] + " ");
            }
            foreach (int value in numbers){
                Total += value;
            }
            Console.WriteLine("The result number is: " + Total);
        }
    }
}
