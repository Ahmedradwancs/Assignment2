namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             
            Console.Clear();
            Console.Title = "Assignment 2 <By: Ahmed Radwan";


            TemperatureConverter temperatureConverter = new TemperatureConverter();

            temperatureConverter.Start();

            ContinueToNextPart("String Functions");

            StringFunctions stringFunctions = new StringFunctions();
            stringFunctions.Start();

            ContinueToNextPart("MathWork");

            MathWork mathWork = new MathWork();
            mathWork.Calculate();

            ContinueToNextPart("Scheduler");

            Scheduler scheduler = new Scheduler();
            scheduler.start();


        }

        private static void ContinueToNextPart(string title)
        {
            Console.WriteLine("\n PRESS ENTER TO CONTINUE TO THE NEXT PART");
            Console.ReadLine();
            Console.Clear();
            Console.Title = title;
            Console.WriteLine("+++++++++++++" + title + "+++++++++++++");



        }

    } 
}
