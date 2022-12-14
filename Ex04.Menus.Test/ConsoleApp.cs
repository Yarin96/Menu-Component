using System;

namespace Ex04.Menus.Test
{
    public class ConsoleApp
    {
        internal void InitApp()
        {
            initMenuStructureWithInterfaces();
            Console.Clear();
            initMenuStructureWithDelegates();
        }

        private void initMenuStructureWithInterfaces()
        {
            const bool v_DefineMenuItemAsMethod = true;
            Interfaces.MenuItem showDateAndTime = new Interfaces.MenuItem("Show Date/Time", null, !v_DefineMenuItemAsMethod);
            showDateAndTime.AddMethodToMenuItem("Show Time", new ShowTimeMethod(), v_DefineMenuItemAsMethod);
            showDateAndTime.AddMethodToMenuItem("Show Date", new ShowDateMethod(), v_DefineMenuItemAsMethod);
            Interfaces.MenuItem showVersionAndSpaces = new Interfaces.MenuItem("Version and Spaces", null, !v_DefineMenuItemAsMethod);
            showVersionAndSpaces.AddMethodToMenuItem("Show Version", new ShowVersionMethod(), v_DefineMenuItemAsMethod);
            showVersionAndSpaces.AddMethodToMenuItem("Count Spaces", new CountSpacesOfSentence(), v_DefineMenuItemAsMethod);
            Interfaces.MainMenu mainMenu = new Interfaces.MainMenu("Interfaces Main Menu");
            mainMenu.AddMenuItemToMainMenu(showDateAndTime);
            mainMenu.AddMenuItemToMainMenu(showVersionAndSpaces);
            mainMenu.Show();
        }

        private void initMenuStructureWithDelegates()
        {
            const bool v_DefineMenuItemAsMethod = true;
            Delegates.MenuItem showDateAndTime = new Delegates.MenuItem("Show Date/Time", null, !v_DefineMenuItemAsMethod);
            Delegates.MenuItem showTime = new Delegates.MenuItem("Show Time", Methods.ShowTime_LaunchedMethod, v_DefineMenuItemAsMethod);
            Delegates.MenuItem showDate = new Delegates.MenuItem("Show Date", Methods.ShowDate_LaunchedMethod, v_DefineMenuItemAsMethod);
            showDateAndTime.AddMethodToMenuItem(showTime);
            showDateAndTime.AddMethodToMenuItem(showDate);
            Delegates.MenuItem showVersionAndSpaces = new Delegates.MenuItem("Version and Spaces", null, !v_DefineMenuItemAsMethod);
            Delegates.MenuItem showVersion = new Delegates.MenuItem("Show Version", Methods.ShowVersion_LaunchedMethod, v_DefineMenuItemAsMethod);
            Delegates.MenuItem countSpaces = new Delegates.MenuItem("Count Spaces", Methods.CountSpacesOfSentence_LaunchedMethod, v_DefineMenuItemAsMethod);
            showVersionAndSpaces.AddMethodToMenuItem(showVersion);
            showVersionAndSpaces.AddMethodToMenuItem(countSpaces);
            Delegates.MainMenu mainMenu = new Delegates.MainMenu("Delegates Main Menu");
            mainMenu.AddMenuItemToMainMenu(showDateAndTime);
            mainMenu.AddMenuItemToMainMenu(showVersionAndSpaces);
            mainMenu.Show();
        }
    }
}