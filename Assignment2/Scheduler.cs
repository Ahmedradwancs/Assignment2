using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Scheduler
    {
        // Create a method that calculates the weekends to work
        public void weekEnds()
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

        // Create a method that calculates the night shifts to work
        public void nightShifts()
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

        // Create a method that displays the menu
        public void displayMenu()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("               YOUR WORK SCHEDULE                  ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1 Show a list of the weekends to work.");
            Console.WriteLine("2 Show a list of the nights to work.");
            Console.WriteLine("0 Exit the program.");
        }

        // Create a method that starts the program
        public void start()
        {
            int choice = 0;
            do
            {
                displayMenu();
                Console.WriteLine();
                Console.Write("Your choice: ");
                choice = int.Parse(Console.ReadLine());
                // Create a switch statement to call the methods
                switch (choice)
                {
                    case 1:
                        weekEnds();
                        break;

                    case 2:
                        nightShifts();
                        break;
                }
            } while (choice != 0);

        }
    }
}
