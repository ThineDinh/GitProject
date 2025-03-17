using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chisocannang
{
    class Program
    {
        static void Main(string[] args)
        {
            bool success = false;
            double height;
            double weight;
            while (!success)
            {
                Console.WriteLine("Please input your height: ");
                success = double.TryParse(Console.ReadLine(), out height);
                Console.WriteLine("Please input your weight: ");
                success = double.TryParse(Console.ReadLine(), out weight);
                double bmi = weight / Math.Pow(height, 2);
                if (success & weight > 0 & height > 0)
                {
                    bmi = Math.Round(bmi, 1);
                    Console.Write("BMI: " + bmi);
                    if (bmi < 18)
                        Console.WriteLine(" Underweight");
                    else if (bmi < 25.0)
                        Console.WriteLine(" Normal");
                    else if (bmi < 30.0)
                        Console.WriteLine(" Overweight");
                    else
                        Console.WriteLine(" Obese");
                }
                else
                {
                    success = false;
                    Console.WriteLine("Invalid input please try again!");
                }
                
                
            }
            
        }
    }
}
