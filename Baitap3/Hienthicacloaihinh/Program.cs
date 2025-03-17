using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Hienthicacloaihinh
{
    class Program
    {

        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("Please select by press the number below:");
            Console.WriteLine("1. Print the rectangle");
            Console.WriteLine("2. Print the square triangle (Top-left)");
            Console.WriteLine("3. Print the square triangle (Top-right)");
            Console.WriteLine("4. Print the square triangle (Bottom-left)");
            Console.WriteLine("5. Print the square triangle (Bottom-right)");
            Console.WriteLine("6. Print isosceles triangle");
            Console.WriteLine("7. Exit");
            Console.WriteLine("------------------------------------------");
            bool success = int.TryParse(Console.ReadLine(), out int inputselect);
            Console.WriteLine("Your selection is: ");
            if (inputselect == 1)
            {
                Console.WriteLine("1. Print the rectangle");
                a = InputProp("Width");
                b = InputProp("Height");
                DrawRectangle(a, b);
            }
            else if (inputselect == 2){
                Console.WriteLine("2. Print the square triangle (Top-left)");
                b = InputProp("Height");
                DrawTriangleTopLeft(b);
            }
            else if (inputselect == 3)
            {
                Console.WriteLine("3. Print the square triangle (Top-right)");
                b = InputProp("Height");
                DrawTriangleTopRight(b);
            }
            else if (inputselect == 4)
            {
                Console.WriteLine("4. Print the square triangle (Bottom-left)");
                b = InputProp("Height");
                DrawTriangleBotLeft(b);
            }
            else if (inputselect == 5)
            {
                Console.WriteLine("5. Print the square triangle (Bottom-Right)");
                b = InputProp("Height");
                DrawTriangleBotRight(b);
            }
            else if (inputselect == 6)
            {
                Console.WriteLine("6. Print isosceles triangle");
                b = InputProp("Height");
                DrawTriangleIsosceles(b);
            }
            else if (inputselect == 7)
            {
                Console.WriteLine("7. Exit");
            }
            else Console.WriteLine("Exit cause by invalid input");
        }

        private static int InputProp(string name)
        {
            bool success = false;
            int output = 0;
            
            while (!success)
            {
                Console.WriteLine("Input " + name);
                success = int.TryParse(Console.ReadLine(), out output);
                if (output <= 0)
                {
                    Console.WriteLine("Please input must be greater than 0");
                    success = false;
                }
            }
            return output;
            
        }
        static void DrawRectangle (int a, int b)
        {
            for (int i = 1; i <= b; i++)
            {
                
                for (int j = 1; j <= a; j++)
                {
                    Console.Write("*");
                };
                Console.WriteLine();
            }
        }
        static void DrawTriangleBotLeft(int b)
        {
            for (int i = 1; i <= b; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                ;
                Console.WriteLine();
            }
        }
        static void DrawTriangleTopLeft(int b)
        {
            for (int i = b; i > 0; i--)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                ;
                Console.WriteLine();
            }
        }
        static void DrawTriangleBotRight(int b)
        {
            for (int i = b; i > 0; i--)
            {

                for (int j = 1; j <= b; j++)
                {
                    if (j < i)
                    {
                        Console.Write(" ");
                    } else Console.Write("*");
                }
                ;
                Console.WriteLine();
            }
        }
        static void DrawTriangleTopRight(int b)
        {
            for (int i = 1; i <= b; i++)
            {

                for (int j = 1; j <= b; j++)
                {
                    if (j < i)
                    {
                        Console.Write(" ");
                    }
                    else Console.Write("*");
                }
                ;
                Console.WriteLine();
            }
        }
        static void DrawTriangleIsosceles(int b)
        {
            for (int i = 1; i <= b; i++)
            {
                for (int j = 0; j < b - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
