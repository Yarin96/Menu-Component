using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowVersionMethod : IMenuMethod
    {
        void IMenuMethod.MenuItemMethod()
        {
            Methods.ShowVersion_LaunchedMethod();
        }
    }
}
