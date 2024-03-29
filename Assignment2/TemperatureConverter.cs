using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class TemperatureConverter
    {
        /// <summary>
        /// This method converts Fahrenheit to Celsius
        /// </summary>
        /// <param name="fahrenheit"></param>
        /// <returns></returns>
        private static double ConvertFahrenheitToCelsius(int fahrenheit)
        {
            // Formula for Fahrenheit to Celsius conversion
            double celsius = ((fahrenheit - 32) * 5.0) / 9.0;
            return celsius;
        }

        /// <summary>
        /// This method converts Celsius to Fahrenheit
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        private static double ConvertCelsiusToFahrenheit(int celsius)
        {
            // Formula for Celsius to Fahrenheit conversion
            double fahrenheit = ((celsius * 9.0) / 5.0) + 32;
            return fahrenheit;
        }

        /// <summary>
        /// This method displays the main menu
        /// </summary>
        private void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine("                 Main Menu                ");
            Console.WriteLine("******************************************");
            Console.WriteLine("        Convert Fahrenhiet to Celsius : 1");
            Console.WriteLine("        Convert Celsius to Fahrehiet  : 2");
            Console.WriteLine("        Exit the converter            : 0");
            Console.WriteLine("******************************************");
            Console.WriteLine();
        }

        /// <summary>
        /// This method starts the temperature converter
        /// </summary>
        public void Start()
        {
            string choice = "0";
            do
            {
                DisplayMenu();
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        for (int i = 0; i <= 212; i += 10)
                        {
                            Console.WriteLine($"{i,6:F2} F = {ConvertFahrenheitToCelsius(i),6:F2} C");
                        }

                        break;

                    case "2":
                        for (int i = 0; i <= 100; i += 5)
                        {
                            Console.WriteLine($"{i,6:F2} C = {ConvertCelsiusToFahrenheit(i),6:F2} F");
                        }
                        break;

                    case "0":
                        Console.WriteLine("Exiting the converter.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            } while (choice != "0");
            Console.WriteLine();

        }


    } 
}
