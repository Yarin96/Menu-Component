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
            m_ShowDateAndTime = new Interfaces.MenuItem("Show Date/Time", null, !v_DefineMenuItemAsMethod);
            m_ShowDateAndTime.AddMethodToMenuItem("Show Time", new ShowTimeMethod(), v_DefineMenuItemAsMethod);
            m_ShowDateAndTime.AddMethodToMenuItem("Show Date", new ShowDateMethod(), v_DefineMenuItemAsMethod);
            m_ShowVersionAndSpaces = new Interfaces.MenuItem("Version and Spaces", null, !v_DefineMenuItemAsMethod);
            m_ShowVersionAndSpaces.AddMethodToMenuItem("Show Version", new ShowVersionMethod(), v_DefineMenuItemAsMethod);
            m_ShowVersionAndSpaces.AddMethodToMenuItem("Count Spaces", new CountSpacesOfSentence(), v_DefineMenuItemAsMethod);
            m_MainMenu.AddMenuItemToMainMenu(m_ShowDateAndTime);
            m_MainMenu.AddMenuItemToMainMenu(m_ShowVersionAndSpaces);
            m_MainMenu.Show();
        }

        private void buildAppMainMenuWithDelegates()
        {
        }
    }
}