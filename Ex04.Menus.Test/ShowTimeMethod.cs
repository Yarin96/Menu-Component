using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowTimeMethod : IMenuMethod
    {
        void IMenuMethod.MenuItemMethod()
        {
            Methods.ShowTime_LaunchedMethod();
        }
    }
}
