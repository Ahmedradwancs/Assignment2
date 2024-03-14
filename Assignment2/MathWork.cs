using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class MathWork
    {
        /// <summary>
        /// When the user selects the MathWork option from the main menu, this method is called.
        /// </summary>
        public void Calculate()
        {
            Console.WriteLine();
            Console.WriteLine("Sum numbers between any two numbers");
            Console.Write("Give number1 number: ");
            //int num1 = int.Parse(Console.ReadLine());
            int num1 = Input.ReadIntegerConsole("Give number1 number: ");
            Console.Write("Give end number: ");
            //int num2 = int.Parse(Console.ReadLine());
            int num2 = Input.ReadIntegerConsole("Give end number: ");
            if (num1 > num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }
            Console.WriteLine("The sum of the numbers between " + num1 + " and " + num2 + " is " + SumNumbers(num1, num2));
            PrintEvenNumbers(num1, num2);
            PrintOddNumbers(num1, num2);
            calculateSquareRoots(num1, num2);

            // Ask the user if he/she wants to exit the program
            if (ExitCalculation())
            {
                return;
            }
            else
            {
                Calculate();
            }
        }


        /// <summary>
        /// Will sum all numbers between two numbers
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private int SumNumbers(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum = sum + i;
            }
            return sum;
        }

        /// <summary>
        /// Will print all even numbers between two numbers
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void PrintEvenNumbers(int start, int end)
        {
            Console.WriteLine("****Even numbers between " + start + " och " + end);

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("\t" + i );
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Will print all odd numbers between two numbers
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void PrintOddNumbers(int start, int end)
        {
            Console.WriteLine("****Odd numbers between " + start + " och " + end);

            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("\t" + i);
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Will calculate the square roots of all numbers between two numbers
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void calculateSquareRoots(int start, int end)

        {
            Console.WriteLine("       ***********  Square Roots  ***********");
            for (int i = start; i <= end; i++)
            {
                Console.Write($"Sqrt({i, 3} to {end} )");
                for (int j = i; j <= end; j++)
                {
                    Console.Write($"{Math.Sqrt(j), 6:F2}");
                }
                Console.WriteLine();
            }

        }

        /// <summary>
        /// Will ask the user if he/she wants to exit the program
        /// </summary>
        /// <returns></returns>
        private bool ExitCalculation()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Exit math work? (y/n)");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "y")
            {
                return true;
            }
            else if (answer.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please answer correctly!");
                return ExitCalculation();
            }
        }

    }
}

