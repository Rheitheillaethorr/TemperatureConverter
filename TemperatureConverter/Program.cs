using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInfo();
            
        }
        static void GetInfo()
        {
            Console.WriteLine("Hello, what temperature scale do you want to convert from?");
            Console.WriteLine("'1' - Celsius");
            Console.WriteLine("'2' - Kelvin");
            Console.WriteLine("'3' - Fahrenheit");
            int choice = int.Parse(Console.ReadLine());      
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
        static void Convert(int Number)
        {
            Console.WriteLine("enter the number of degrees: ");
            float degrees = float.Parse(Console.ReadLine());
            switch (Number)
            {
                case 1:
                    Console.WriteLine(degrees + " Celsius are " + (degrees + 273.15) + " Kelvin");
                    Console.WriteLine(degrees + " Celsius are " + (degrees * 1.8 + 32) + " Fahrenheit");
                    break;
                case 2:
                    Console.WriteLine(degrees + " Kelvin are " + (degrees - 273.15) + " Celsius");
                    Console.WriteLine(degrees + " Kelvin are " + ((degrees - 273.15) * 1.8 + 32) + " Fahrenheit");
                    break;
                case 3:
                    Console.WriteLine(degrees + " Fahrenheit are " + (((degrees-32)*5)/9) + " Celsius");
                    Console.WriteLine(degrees + " Fahrenheit are " + ((((degrees-32)*5)/9)+273.15) + " Kelvin");
                    break;
            }
        }
    }
}
