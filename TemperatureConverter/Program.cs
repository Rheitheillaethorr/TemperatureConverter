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
                    //Convert(choice);
                    break;
                case 2:
                    Console.WriteLine("You choosed Kelvin");
                    //Convert(choice);
                    break;
                case 3:
                    Console.WriteLine("You choosed Fahrenheit");
                    //Convert(choice);
                    break;
                default:
                    Console.WriteLine("You choosed wrong number, try again");
                    GetInfo();
                    break;
            }
        }
    }
}
