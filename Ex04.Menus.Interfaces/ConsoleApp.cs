namespace Ex04.Menus.Interfaces
{
    public class ConsoleApp
    {
        public void InitApp()
        {
            buildAppMainMenu();
        }

        private static void buildAppMainMenu()
        {
            MainMenu m_MainMenu = new MainMenu("Interfaces Main Menu");
            MenuItem showDateAndTime = new MenuItem("Show Date/Time", false);
            showDateAndTime.addItemToMenu("Show Time", true);
            showDateAndTime.addItemToMenu("Show Date", true);
            MenuItem showVersionAndSpaces = new MenuItem("Version and Spaces", false);
            showVersionAndSpaces.addItemToMenu("Show Version", true);
            showVersionAndSpaces.addItemToMenu("Count Spaces", true);
            m_MainMenu.m_CurrentMenuItems.Add(showDateAndTime);
            m_MainMenu.m_CurrentMenuItems.Add(showVersionAndSpaces);
            m_MainMenu.Show();
        }
    }
}
