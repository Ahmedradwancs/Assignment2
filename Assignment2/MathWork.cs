using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class MathWork
    {
        //Create the class method that calls other methods
        public void Calculate()
        {
            Console.WriteLine();
            Console.WriteLine("Sum numbers between any two numbers");
            Console.Write("Give number1 number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Give end number: ");
            int num2 = int.Parse(Console.ReadLine());
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


        //Create the method that adds the values from a start number to an end number
        private int SumNumbers(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum = sum + i;
            }
            return sum;
        }

        //Create the method that prints the even numbers from a start number to an end number
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

        //Create the method that prints the odd numbers from a start number to an end number
        private void PrintOddNumbers(int start, int end)
        {
            Console.WriteLine("****Odd numbers between " + start + " och " + end);

            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("\t" + i);
                }
            }
            Console.WriteLine();
        }

        //Create the method that calculates the square root of all numbers between two numbers
        private void calculateSquareRoots(int start, int end)

        {
            Console.WriteLine("       ***********  Square Roots  ***********");
            for (int i = start; i <= end; i++)
            {
                Console.Write($"Sqrt ({i} to {end}  )");
                for (int j = i; j <= end; j++)
                {
                    Console.Write($"{Math.Sqrt(j), 6:F2}");
                }
                Console.WriteLine();
            }

        }

        private bool ExitCalculation()
        {
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
