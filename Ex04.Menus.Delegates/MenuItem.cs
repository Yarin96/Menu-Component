using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        public event Action LaunchedMethod;

        private readonly string r_MenuItemName;
        private readonly bool r_IsMenuItemMethod;
        private readonly List<MenuItem> r_MenuItems;

        public MenuItem(string i_MenuItemName, Action i_MethodToInvoke, bool i_IsMenuItemMethod)
        {
            r_MenuItems = new List<MenuItem>();
            r_MenuItemName = i_MenuItemName;
            r_IsMenuItemMethod = i_IsMenuItemMethod;
            checkIfMenuItemIsMethodAndAddAsListener(i_MethodToInvoke, i_IsMenuItemMethod);
        }

        private void checkIfMenuItemIsMethodAndAddAsListener(Action i_MethodToInvoke, bool i_IsMenuItemMethod)
        {
            LaunchedMethod += i_IsMenuItemMethod ? new Action(i_MethodToInvoke) : null;
        }

        public string MenuItemName
        {
            get { return r_MenuItemName; }
        }

        public bool IsMenuItemMethod
        {
            get { return r_IsMenuItemMethod; }
        }

        public List<MenuItem> MenuItems
        {
            get { return r_MenuItems; }
        }

        public void AddMethodToMenuItem(MenuItem i_MenuItemMethod)
        {
            r_MenuItems.Add(i_MenuItemMethod);
        }

        internal void ActivateMenuItemMethod()
        {
            OnLaunchedMethod();
        }

        protected virtual void OnLaunchedMethod()
        {
            LaunchedMethod?.Invoke();
        }
    }
}
