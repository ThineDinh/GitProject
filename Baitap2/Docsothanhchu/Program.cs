using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Docsothanhchu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number: ");
            int Number = int.Parse(Console.ReadLine());
            int Hundred = Number / 100;
            Number = Number % 100;
            int Ten = Number / 10;
            Number = Number % 10;
            Console.WriteLine("Result: " + Hundred +" "+ Ten + " " + Number);
            Console.Write("=> ");
            if (Hundred > 0)
            {
                if (Hundred == 1)
                {
                    Console.Write("One hundred ");
                }
                else
                {
                    Writenumb(Hundred);
                    Console.Write(" hundreds ");
                }
                    
            }
            if (Ten > 0)
            {
                if (Ten == 1)
                    switch (Number)
                    {
                        case (0):
                            Console.Write("Ten");
                            break;
                        case (1):
                            Console.Write("Eleven");
                            break;
                        case (2):
                            Console.Write("Twelve");
                            break;
                        case (3):
                            Console.Write("Thirdteen");
                            break;
                        case (5):
                            Console.Write("Fifteen");
                            break;
                        default:
                            Console.Write(Ten + "teen");
                            break;
                    }
                else if (Ten == 2)
                {
                    Console.Write("Twenty ");
                }
                else if (Ten == 3)
                {
                    Console.Write("Thirdty ");
                }
                else if (Ten == 5)
                {
                    Console.Write("Fifty ");
                }
                else
                {
                    Writenumb(Ten);
                    Console.Write("ty ");
                }
            }
            if (Number > 0 & Ten != 1)
            {
                Writenumb(Number);
            }
        }
        public static void Writenumb(int i)
        {
            switch (i)
            {
                case (1):
                    Console.Write("One");
                    break;
                case (2):
                    Console.Write("Two");
                    break;
                case (3):
                    Console.Write("Three");
                    break;
                case (4):
                    Console.Write("Four");
                    break;
                case (5):
                    Console.Write("Five");
                    break;
                case (6):
                    Console.Write("Six");
                    break;
                case (7):
                    Console.Write("Seven");
                    break;
                case (8):
                    Console.Write("Eight");
                    break;
                case (9):
                    Console.Write("Nine");
                    break;
            }
        }
    }
}
