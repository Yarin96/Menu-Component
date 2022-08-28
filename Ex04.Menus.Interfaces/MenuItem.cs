using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : IMenuItemDetails
    {
        private string m_MenuItemName;
        private bool m_IsItemMethod;
        private List<MenuItem> m_MenuItems;
        private IMenuMethod m_MenuItemMethod;

        public MenuItem(string i_MenuItemName, IMenuMethod i_MenuItemMethod, bool i_isMethod)
        {
            m_MenuItems = new List<MenuItem>();
            m_MenuItemName = i_MenuItemName;
            m_MenuItemMethod = i_MenuItemMethod;
            m_IsItemMethod = i_isMethod;
        }

        public void AddMethodToMenuItem(string i_ItemMethodName, IMenuMethod i_MenuItemMethod, bool i_isMethod)
        {
            m_MenuItems.Add(new MenuItem(i_ItemMethodName, i_MenuItemMethod, i_isMethod));
        }

        internal void ActivateMethod()
        {
            m_MenuItemMethod.MenuItemMethod();
        }

        public string MenuItemName
        {
            get { return m_MenuItemName; }
            set { m_MenuItemName = value; }
        }

        public bool IsItemMethod
        {
            get { return m_IsItemMethod; }
            set { m_IsItemMethod = value; }
        }

        public List<MenuItem> MenuItems
        {
            get { return m_MenuItems; }
        }
    }
}
