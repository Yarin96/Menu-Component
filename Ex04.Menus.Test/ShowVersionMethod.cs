﻿using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowVersionMethod : IMenuMethod
    {
        private const string k_CurrentAppVersion = "Version: 22.3.4.8650";

        void IMenuMethod.MenuItemMethod()
        {
            Console.WriteLine(k_CurrentAppVersion);
        }
    }
}
