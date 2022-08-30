using System;

namespace Ex04.Menus.Test
{
    public class Methods
    {
        private const string k_CurrentAppVersion = "Version: 22.3.4.8650";

        public static void CountSpacesOfSentence_LaunchedMethod()
        {
            int numOfSpacesInSentence = 0;
            Console.WriteLine("Please type your sentence:");
            string userSentenceInput = Console.ReadLine();

            foreach (char character in userSentenceInput)
            {
                if (character == ' ')
                {
                    numOfSpacesInSentence++;
                }
            }

            string amountOfSpacesMessage = $"The entered sentence has {numOfSpacesInSentence} spaces in it.";
            Console.WriteLine(amountOfSpacesMessage);
        }

        public static void ShowVersion_LaunchedMethod()
        {
            Console.WriteLine(k_CurrentAppVersion);
        }

        public static void ShowDate_LaunchedMethod()
        {
            DateTime currentDate = DateTime.UtcNow;
            string currentDateMessage = $"The current date is {currentDate.Date:d}.";
            Console.WriteLine(currentDateMessage);
        }

        public static void ShowTime_LaunchedMethod()
        {
            DateTime currentTime = DateTime.Now;
            string currentTimeMessage = $"The current time is {currentTime:HH:mm:ss tt}.";
            Console.WriteLine(currentTimeMessage);
        }
    }
}
