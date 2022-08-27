using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : IMenuItemDetails
    {
        internal string m_MenuItemName;
        internal bool m_IsItemMethod;
        internal List<MenuItem> m_MenuItems;

        public MenuItem(string i_MenuItemName, bool i_isMethod)
        {
            m_MenuItems = new List<MenuItem>();
            m_MenuItemName = i_MenuItemName;
            m_IsItemMethod = i_isMethod;
        }

        internal void addItemToMenu(string i_ItemMethodName, bool i_isMethod)
        {
            m_MenuItems.Add(new MenuItem(i_ItemMethodName, i_isMethod));
        }

        string IMenuItemDetails.MenuItemName
        {
            get => m_MenuItemName;
            set => m_MenuItemName = value;
        }

        bool IMenuItemDetails.IsItemMethod
        {
            get => m_IsItemMethod;
            set => m_IsItemMethod = value;
        }
    }
}
