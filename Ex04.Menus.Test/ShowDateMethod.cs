using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowDateMethod : IMenuMethod
    {
        void IMenuMethod.MenuItemMethod()
        {
            Methods.ShowDate_LaunchedMethod();
        }
    }
}
