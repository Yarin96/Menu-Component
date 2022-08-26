using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : IMenuItem
    {
        private string m_MenuItemName;
        private bool m_IsMethod;
        private IMenuItem m_MenuItem;
        private List<SubMenu> m_SubMenu;
        private StringBuilder m_CurrentMenuDetails = new StringBuilder();

        string IMenuItem.MenuItemName
        {
            get { return m_MenuItemName; }
            set { m_MenuItemName = value; }
        }

        bool IMenuItem.IsItemMethod
        {
            get { return m_IsMethod; }
            set { m_IsMethod = value; }
        }

        public List<SubMenu> NextSubMenu
        {
            get { return m_SubMenu; }
            set { m_SubMenu = value; }
        }

        private void setItemAsSubMenu(int i_NumberOfItemsInSubMenu, string i_SubMenuName)
        {
            m_MenuItem.MenuItemName = i_SubMenuName;
            m_MenuItem.IsItemMethod = false;
            m_SubMenu = new List<SubMenu>(i_NumberOfItemsInSubMenu);
        }

        private void setItemAsMethod(string i_MethodName)
        {
            m_MenuItem.MenuItemName = i_MethodName;
            m_MenuItem.IsItemMethod = true;
            m_SubMenu = null;
        }
    }
}
