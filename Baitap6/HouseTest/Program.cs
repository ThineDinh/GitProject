using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseTest
{
    public class House
    {
        public string Name = "House";

        public House(string Name)
        {
            this.Name = Name;
        }
    }
    class Program
    {
        static void Swaphouse(House House, string Name)
        {
            House.Name = Name;
        }
        static void Main(string[] args)
        {
            House House1 = new House("HouseA");
            Swaphouse(House1, "HouseB");
            Console.WriteLine(House1.Name);
        }
    }
}
