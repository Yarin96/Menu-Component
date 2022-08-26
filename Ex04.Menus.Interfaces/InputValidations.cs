using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
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
                throw new FormatException("input is not a valid Menu choice. Press Enter to try again.");
            }

            if (userChoice != 0)
            {
                userChoice--;
            }

            return userChoice;
        }
    }
}
