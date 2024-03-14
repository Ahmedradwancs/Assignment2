using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Scheduler
    {
        /// <summary>
        /// When the user selects the  weekends option from the main menu, this method is called.
        /// </summary>
        private void weekEnds()
        {
            for (int week = 2; week <= 52; week += 8)
            {
                // This is how I managed to print the weeks in the format of 4 weeks per line
                for (int i = 0; i < 8 && week + i <= 52; i += 2)
                {
                    Console.Write($"Week {week + i:D2} \t");
                }
            Console.WriteLine();
            }
        }

        /// <summary>
        /// When the user selects the nightshifts option from the main menu, this method is called.
        /// </summary>
        private void nightShifts()
        {
            for (int week = 1; week <= 52; week += 16)
            {
                for (int i = 0; i < 16 && week + i <= 52; i+= 4)
                {
                    Console.Write($"Week {week + i:D2} \t");
                }
                Console.WriteLine();
            }

        }

        /// <summary>
        /// When the user selects the main menu option from the main menu, this method is called.
        /// </summary>
        private void displayMenu()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("               YOUR WORK SCHEDULE                  ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1 Show a list of the weekends to work.");
            Console.WriteLine("2 Show a list of the nights to work.");
            Console.WriteLine("0 Exit the program.");
        }

        /// <summary>
        /// When the user selects the start option from the main menu, this method is called.
        /// </summary>
        public void start()
        {
            string choice = "0";
            do
            {
                displayMenu();
                Console.WriteLine();
                Console.Write("Your choice: ");
                choice = Console.ReadLine();
                // Create a switch statement to call the methods
                switch (choice)
                {
                    case "1":
                        weekEnds();
                        break;

                    case "2":
                        nightShifts();
                        break;

                    case "0":
                        Console.WriteLine("Exiting the program.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            } while (choice != "0");

        }
    }
}
