using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowDateMethod : IMenuMethod
    {
        void IMenuMethod.MenuItemMethod()
        {
            DateTime currentDate = DateTime.UtcNow;
            string currentDateMessage = $"The current date is {currentDate.Date:d}.";
            Console.WriteLine(currentDateMessage);
        }
    }
}
