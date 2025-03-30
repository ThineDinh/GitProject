using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopHinhChuNhat
{
    public class Rectangle
    {
        double width, height;
        public Rectangle()
        {

        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double GetArea()
        {
            return this.width * this.height;
        }
        public double GetPerimeter()
        {
            return (this.width + this.height) * 2;
        }
        public string Display()
        {
            return (this.width + " " + this.height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input rectangle's width: ");
            double width = Double.Parse(Console.ReadLine());
            Console.WriteLine("Input rectangle's height: ");
            double height = Double.Parse(Console.ReadLine());

            Rectangle RectangleObj = new Rectangle(width, height);
            Console.WriteLine("Rectangle: " + RectangleObj.Display());
            Console.WriteLine("Area: " + RectangleObj.GetArea());
            Console.WriteLine("Perimeter: " + RectangleObj.GetPerimeter());
        }
    }
}
