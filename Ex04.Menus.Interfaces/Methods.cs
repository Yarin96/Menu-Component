using System;

namespace Ex04.Menus.Interfaces
{
    internal class Methods
    {
        internal static void CountSpacesOfSentence()
        {
            int numOfSpacesInSentence = 0;
            Console.WriteLine("Please type your sentence:");
            string userSentenceInput = Console.ReadLine();

            foreach(char character in userSentenceInput)
            {
                if(character == ' ')
                {
                    numOfSpacesInSentence++;
                }
            }

            string output = $"The entered sentence has {numOfSpacesInSentence} spaces in it.";
            Console.WriteLine(output);
        }

        internal static void ShowVersion()
        {
            Console.WriteLine("Version: 22.3.4.8650");
        }

        internal static void ShowTime()
        {
            DateTime currentTime = DateTime.Now;
            string output = $"The current time is {currentTime:HH:mm:ss tt}.";
            Console.WriteLine(output);
        }

        internal static void ShowDate()
        {
            DateTime currentDate = DateTime.UtcNow;
            string output = $"The current date is {currentDate.Date:d}.";
            Console.WriteLine(output);
        }
    }
}
