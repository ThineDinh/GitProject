using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insonguyento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number N: ");
            bool success = int.TryParse(Console.ReadLine(), out int N);
            if (N <= 1)
            {
                Console.WriteLine("Invalid input please enter number that greater than 1");
            }
            else
            {
                for (int j = 2; j < N; j++)
                {
                    CheckNumber(j);
                }
            }
        }

        static void CheckNumber(int a)
        {
            bool IsNumber = true;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    IsNumber = false;
                    break;
                }
            }
            if (IsNumber) Console.Write(a + " ");
        }
    }
}
