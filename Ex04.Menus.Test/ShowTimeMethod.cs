using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowTimeMethod : IMenuMethod
    {
        void IMenuMethod.MenuItemMethod()
        {
            DateTime currentTime = DateTime.Now;
            string currentTimeMessage = $"The current time is {currentTime:HH:mm:ss tt}.";
            Console.WriteLine(currentTimeMessage);
        }
    }
}
