using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : IMenuItemDetails
    {
        private string m_MenuItemName;
        private bool m_IsItemMethod;
        private List<MenuItem> m_MenuItems;
        private IMenuMethod m_MenuItemMethod;

        public MenuItem(string i_MenuItemName, IMenuMethod i_MenuItemMethod, bool i_IsMethod)
        {
            m_MenuItems = new List<MenuItem>();
            m_MenuItemName = i_MenuItemName;
            m_MenuItemMethod = i_MenuItemMethod;
            m_IsItemMethod = i_IsMethod;
        }

        public string MenuItemName
        {
            get { return m_MenuItemName; }
        }

        public bool IsMenuItemMethod
        {
            get { return m_IsItemMethod; }
        }

        public List<MenuItem> MenuItems
        {
            get { return m_MenuItems; }
        }

        public void AddMethodToMenuItem(string i_ItemMethodName, IMenuMethod i_MenuItemMethod, bool i_IsMethod)
        {
            m_MenuItems.Add(new MenuItem(i_ItemMethodName, i_MenuItemMethod, i_IsMethod));
        }

        internal void ActivateMethod()
        {
            m_MenuItemMethod.MenuItemMethod();
        }
    }
}
