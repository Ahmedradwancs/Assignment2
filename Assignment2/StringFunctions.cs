using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class StringFunctions
    {
        /// <summary>
        /// When the user selects the StringFunctions option from the main menu, this method is called.
        /// </summary>
        /// <param name="input"></param>
        public void StringLength(string input)
        {
            int length = input.Length;
            Console.WriteLine(" ----- STRENGTH LENGTH ----- ");
            Console.WriteLine();
            Console.WriteLine(input.ToUpper());
            Console.WriteLine($"Number of chars = {length}");
            Console.WriteLine();
        }

        /// <summary>
        /// This method predicts the user's day based on the number he/she selects.
        /// </summary>
        public void PredictMyDay()
        {
            Console.WriteLine();
            Console.WriteLine("********** The Fortune Teller **********");
            Console.WriteLine("Let me predict your day! Select a number between 1 and 7: ");
            String day = Console.ReadLine();
            switch (day)
            {
                case "1":
                    Console.WriteLine("Keep calm on Mondays! You can fall apart!");
                    break;

                case "2":
                    Console.WriteLine("Tuesdays and Wednesdays break your heart!");
                    break;

                case "3":
                    Console.WriteLine("Tuesdays and Wednesdays break your heart!");
                    break;

                case "4":
                    Console.WriteLine("Thursday is your lucky day, don't wait for Friday!");
                    break;

                case "5":
                    Console.WriteLine("Friday, you are in love!");
                    break;

                case "6":
                    Console.WriteLine("Saturday, do nothing and do plenty of it!");
                    break;

                case "7":
                    Console.WriteLine("And Sunday always comes too soon!");
                    break;

                default:
                    Console.WriteLine("No day? A good day but it doesn't exist!");
                    break;
            }
            Console.WriteLine();


        }

        /// <summary>
        /// This method asks the user if he/she wants to continue with another round.
        /// </summary>
        public void RunAgain()
        {
            Console.Write("Continue with another round? (y/n): ");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "y")
            {
                Start();
            }
            else if (answer.ToLower() == "n")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid input. Please answer correctly!");
                RunAgain();
            }

        }

        /// <summary>
        /// This method starts the program.
        /// </summary>
        public void Start()
        {
                // Console.WriteLine("++++++++++++++++ String Functions!  ++++++++++++");
                Console.WriteLine("Write a text with any number of characters and press enter!");
                Console.WriteLine("You can even copy a text from a file and paste it here!");
                Console.WriteLine();
                string choice = Console.ReadLine();
                StringLength(choice);
                PredictMyDay();
                RunAgain();
                Console.WriteLine();
            
        }



    }
}
