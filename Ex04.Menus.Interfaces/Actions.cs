using System;

namespace Ex04.Menus.Interfaces
{
    internal class Actions
    {
        internal static void countSpaces()
        {
            int numOfSpacesInSentence = 0;
            Console.WriteLine("Please enter a string:");
            string input = Console.ReadLine();

            foreach(char character in input)
            {
                if(character == ' ')
                {
                    numOfSpacesInSentence++;
                }
            }

            string output = $"The entered sentence has {numOfSpacesInSentence} spaces in it.";
            Console.WriteLine(output);
        }

        internal static void showVersion()
        {
            Console.WriteLine("Version: 22.3.4.8650");
        }

        internal static void showTime()
        {
            DateTime currentTime = DateTime.Now;
            string output = $"The current time is {currentTime:HH:mm:ss tt}.";
            Console.WriteLine(output);
        }

        internal static void showDate()
        {
            DateTime currentDate = DateTime.UtcNow;
            string output = $"The current date is {currentDate.Date:d}.";
            Console.WriteLine(output);
        }
    }
}
