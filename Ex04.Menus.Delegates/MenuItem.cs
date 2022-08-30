using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        public event Action LaunchedMethod;

        private string m_MenuItemName;
        private bool m_IsMenuItemMethod;
        private List<MenuItem> m_MenuItems;

        public MenuItem(string i_MenuItemName, Action i_MethodToInvoke, bool i_IsMenuItemMethod)
        {
            m_MenuItems = new List<MenuItem>();
            m_MenuItemName = i_MenuItemName;
            m_IsMenuItemMethod = i_IsMenuItemMethod;
            checkIfMenuItemIsMethodAndAddAsListener(i_MethodToInvoke, i_IsMenuItemMethod);
        }

        private void checkIfMenuItemIsMethodAndAddAsListener(Action i_MethodToInvoke, bool i_IsMenuItemMethod)
        {
            LaunchedMethod += i_IsMenuItemMethod ? new Action(i_MethodToInvoke) : null;
        }

        public string MenuItemName
        {
            get { return m_MenuItemName; }
        }

        public bool IsMenuItemMethod
        {
            get { return m_IsMenuItemMethod; }
        }

        public List<MenuItem> MenuItems
        {
            get { return m_MenuItems; }
        }

        public void AddMethodToMenuItem(MenuItem i_MenuItemMethod)
        {
            m_MenuItems.Add(i_MenuItemMethod);
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
