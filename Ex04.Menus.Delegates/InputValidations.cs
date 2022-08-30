using System;

namespace Ex04.Menus.Delegates
{
    public class InputValidations
    {
        internal static int CheckIfValidMenuChoice(string i_UserMenuChoice, int i_AmountOfItemsInList)
        {
            int userChoice = 0;

            if (int.TryParse(i_UserMenuChoice, out int o_validChoice))
            {
                if (o_validChoice >= 0 || o_validChoice < i_AmountOfItemsInList)
                {
                    userChoice = o_validChoice;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                throw new FormatException("Input is not a valid Menu choice (Probably not a number). Press 'Enter' to try again.");
            }

            if (userChoice != 0)
            {
                userChoice--;
            }

            return userChoice;
        }
    }
}
