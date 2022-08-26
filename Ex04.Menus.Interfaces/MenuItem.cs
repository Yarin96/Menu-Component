using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : IMenuItemDetails
    {
        internal string m_MenuItemName;
        internal bool m_IsItemMethod;
        internal List<MenuItem> m_MenuItems;

        public MenuItem(string i_MenuItemName)
        {
            m_MenuItems = new List<MenuItem>();
            m_MenuItemName = i_MenuItemName;
        }

        internal void addItemToMenu(string i_ItemMethodName)
        {
            m_MenuItems.Add(new MenuItem(i_ItemMethodName));
        }

        internal void addItemAsMenu(MenuItem i_MenuItem)
        {
            m_MenuItems.Add(i_MenuItem);
        }

        string IMenuItemDetails.MenuItemName
        {
            get { return m_MenuItemName; }
            set { m_MenuItemName = value; }
        }

        bool IMenuItemDetails.IsItemMethod
        {
            get { return m_IsItemMethod; }
            set { m_IsItemMethod = value; }
        }
    }
}
