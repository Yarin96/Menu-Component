using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : IMenuItemDetails
    {
        private readonly string r_MenuItemName;
        private readonly bool r_IsItemMethod;
        private readonly List<MenuItem> r_MenuItems;
        private readonly IMenuMethod r_MenuItemMethod;

        public MenuItem(string i_MenuItemName, IMenuMethod i_MenuItemMethod, bool i_IsMethod)
        {
            r_MenuItems = new List<MenuItem>();
            r_MenuItemName = i_MenuItemName;
            r_MenuItemMethod = i_MenuItemMethod;
            r_IsItemMethod = i_IsMethod;
        }

        public string MenuItemName
        {
            get { return r_MenuItemName; }
        }

        public bool IsMenuItemMethod
        {
            get { return r_IsItemMethod; }
        }

        public List<MenuItem> MenuItems
        {
            get { return r_MenuItems; }
        }

        public void AddMethodToMenuItem(string i_ItemMethodName, IMenuMethod i_MenuItemMethod, bool i_IsMethod)
        {
            r_MenuItems.Add(new MenuItem(i_ItemMethodName, i_MenuItemMethod, i_IsMethod));
        }

        internal void ActivateMethod()
        {
            r_MenuItemMethod.MenuItemMethod();
        }
    }
}
