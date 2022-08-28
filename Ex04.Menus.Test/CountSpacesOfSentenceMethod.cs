using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class CountSpacesOfSentence : IMenuMethod
    {
        void IMenuMethod.MenuItemMethod()
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
    }
}
