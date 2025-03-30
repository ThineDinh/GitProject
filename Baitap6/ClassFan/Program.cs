using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFan
{
    public class Fan
    {
        public const int SLOW = 1;
        public const int MEDIUM = 2;
        public const int FAST = 3;

        // Các trường dữ liệu
        private int speed;
        private bool on;
        private double radius;
        private string color;

        // Getter và Setter
        public int Speed { get => speed; set => speed = value; }
        public bool On { get => on; set => on = value; }
        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }

        public Fan()
        {
            this.speed = SLOW;
            this.on = false;
            this.radius = 5;
            this.color = "blue";
        }
        public override string ToString()
        {
            if (on)
            {
                return $"Fan speed: {speed}, Color: {color}, Radius: {radius}, fan is on";
            }
            else
            {
                return $"Fan Color: {color}, Radius: {radius}, fan is off";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng Fan 1
            Fan fan1 = new Fan();
            fan1.Speed = Fan.FAST;
            fan1.Radius = 10;
            fan1.Color = "yellow";
            fan1.On = true;

            // Tạo đối tượng Fan 2
            Fan fan2 = new Fan();
            fan2.Speed = Fan.MEDIUM;
            fan2.Radius = 5;
            fan2.Color = "blue";
            fan2.On = false;

            // Hiển thị thông tin
            Console.WriteLine(fan1.ToString());
            Console.WriteLine(fan2.ToString());
        }
    }
}
