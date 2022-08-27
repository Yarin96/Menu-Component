using Ex04.Menus.Interfaces;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class ConsoleApp
    {
        private const bool v_DefineMenuItemAsMethod = true;
        private Interfaces.MainMenu m_MainMenu;
        private Interfaces.MenuItem m_ShowDateAndTime;
        private Interfaces.MenuItem m_ShowVersionAndSpaces;

        internal void InitApp()
        {
            buildAppMainMenuWithInterfaces();
            buildAppMainMenuWithDelegates();
        }

        private void buildAppMainMenuWithInterfaces()
        {
            m_MainMenu = new Interfaces.MainMenu("Interfaces Main Menu");
            m_ShowDateAndTime = new Interfaces.MenuItem("Show Date/Time", !v_DefineMenuItemAsMethod);
            m_ShowDateAndTime.AddItemToMenu("Show Time", v_DefineMenuItemAsMethod);
            m_ShowDateAndTime.AddItemToMenu("Show Date", v_DefineMenuItemAsMethod);
            m_ShowVersionAndSpaces = new Interfaces.MenuItem("Version and Spaces", !v_DefineMenuItemAsMethod);
            m_ShowVersionAndSpaces.AddItemToMenu("Show Version", v_DefineMenuItemAsMethod);
            m_ShowVersionAndSpaces.AddItemToMenu("Count Spaces", v_DefineMenuItemAsMethod);
            m_MainMenu.AddItemToMainMenu(m_ShowDateAndTime);
            m_MainMenu.AddItemToMainMenu(m_ShowVersionAndSpaces);
            m_MainMenu.Show();
        }

        private void buildAppMainMenuWithDelegates()
        {
        }
    }
}