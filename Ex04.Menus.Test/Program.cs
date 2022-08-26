using Ex04.Menus.Interfaces;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new Interfaces.MainMenu("Interfaces Main Menu", 0).DefineAndRunMenu();
            /// new Delegates.MenuCreation("Delegates Main Menu").DefineAndRunMenu();
        }
    }
}
