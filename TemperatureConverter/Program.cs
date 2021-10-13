using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what temperature scale do you want to convert from?");
            GetInfo();
            Again();
        }
        static void GetInfo()
        {
            Console.WriteLine("'1' - Celsius");
            Console.WriteLine("'2' - Kelvin");
            Console.WriteLine("'3' - Fahrenheit");
            string GivenInfo = Console.ReadLine();
            try
            {
                int choice = int.Parse(GivenInfo);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You choosed Celsius");
                        Convert(1);
                        break;
                    case 2:
                        Console.WriteLine("You choosed Kelvin");
                        Convert(2);
                        break;
                    case 3:
                        Console.WriteLine("You choosed Fahrenheit");
                        Convert(3);
                        break;
                    default:
                        Console.WriteLine("You choosed wrong number, try again");
                        GetInfo();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not an integer" , GivenInfo);
                Console.WriteLine("Try again!");
                GetInfo();
            }

        }
        static void Convert(int Number)
        {
            Console.WriteLine("enter the number of degrees: ");
            string GivenDegrees = Console.ReadLine();
            try
            {
                float degrees = float.Parse(GivenDegrees);
                switch (Number)
                {
                    case 1:
                        Console.WriteLine(degrees + " Celsius are " + Math.Round(degrees + 273.15, 2) + " Kelvin");
                        Console.WriteLine(degrees + " Celsius are " + Math.Round(degrees * 1.8 + 32, 2) + " Fahrenheit");
                        break;
                    case 2:
                        Console.WriteLine(degrees + " Kelvin are " + Math.Round(degrees - 273.15, 2) + " Celsius");
                        Console.WriteLine(degrees + " Kelvin are " + Math.Round((degrees - 273.15) * 1.8 + 32, 2) + " Fahrenheit");
                        break;
                    case 3:
                        Console.WriteLine(degrees + " Fahrenheit are " + Math.Round(((degrees - 32) * 5) / 9, 2) + " Celsius");
                        Console.WriteLine(degrees + " Fahrenheit are " + Math.Round((((degrees - 32) * 5) / 9) + 273.15, 2) + " Kelvin");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not an integer", GivenDegrees);
                Console.WriteLine("Try again!");
                Convert(Number);
            }
        }
        static void Again()
        {
            Console.WriteLine("Do you want to try again?");
            Console.WriteLine("'yes' or anything for no");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                GetInfo();
                Again();
            }
            else
            {
                Console.WriteLine("Thanks for using my converter");
            }
        }
    }
}
