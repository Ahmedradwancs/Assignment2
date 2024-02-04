namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureConverter temperatureConverter = new TemperatureConverter();

            temperatureConverter.Start();

            ContinueToNextPart("String Functions");

            StringFunctions stringFunctions = new StringFunctions();
            stringFunctions.Start();

            ContinueToNextPart("Scheduler");
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
