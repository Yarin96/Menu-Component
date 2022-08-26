using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class InputValidations
    {
        internal static int CheckIfValidMenuChoice(string i_UserMenuChoice, List<MenuItem> i_MenuItems)
        {
            int userChoice = 0;

            if (int.TryParse(i_UserMenuChoice, out int o_validChoice))
            {
                if (o_validChoice >= 0 || o_validChoice < i_MenuItems.Count)
                {
                    userChoice = o_validChoice;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Input is not a valid Menu choice.");
                }
            }
            else
            {
                throw new FormatException("Input is not a valid Menu choice.");
            }

            if (userChoice != 0)
            {
                userChoice--;
            }

            return userChoice;
        }
    }
}
