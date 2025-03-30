using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
public enum Color
{
    Red = 0,
    Blue = 1,
    Green = 2
}

public class House
{
    public Color color;
    public string address;
    public int number;

    public House()
    {
    }

    public House(Color color, string address, int number)
    {
        this.color = color;
        this.address = address;
        this.number = number;
    }
}
public class Program
{

    public static List<House> houses = new List<House>();
    public static Dictionary<Color, List<House>> housesByColor = new Dictionary<Color, List<House>>();

    public static Dictionary<Color, Dictionary<int, List<House>>> housesByColorAndByNumber;


    public static void AddInputHouse()
    {
        houses.Add(new House(Color.Blue, "7 dinh tien hoang", 5));
        houses.Add(new House(Color.Red, "dinh le", 7));
        houses.Add(new House(Color.Green, "dinh ti", 3));
        houses.Add(new House(Color.Red, "d hoang", 4));
        houses.Add(new House(Color.Green, "dinhng", 5));
        houses.Add(new House(Color.Blue, "dinh ng", 5));


    }
    public static void AddHousesToDictionary()
    {
        foreach (House house in houses)
        {
            Color color = house.color;
            int numPlayer = house.number;
            if (housesByColor.ContainsKey(color))
            {
                housesByColor[color].Add(house);
            }
            else
            {
                housesByColor.Add(color, new List<House>());
            }
        }
    }

    public void AddToHouseNumberDict()
    {

    }


    public static House FindHouse(Color color, int number)
    {
        bool foundColor = housesByColor.TryGetValue(color, out List<House> value);
        if (!foundColor)
        {
            Console.WriteLine("khong tim thay");
            return null;
        }
        foreach (House house in value)
        {
            if (house.number == number)
            {
                Console.WriteLine("tim thay: " + house.address);
                return house;
            }
        }
        Console.WriteLine("khong tim thay");
        return null;
    }

    public static void Main(string[] args)
    {
        AddInputHouse();
        AddHousesToDictionary();
        FindHouse(Color.Blue, 5);


    }
}