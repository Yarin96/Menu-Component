namespace Ex04.Menus.Interfaces
{
    public class ConsoleApp
    {
        public void InitApp()
        {
            buildAppMainMenu();
        }

        private void buildAppMainMenu()
        {
            MainMenu m_MainMenu = new MainMenu("Interfaces Main Menu");
            MenuItem showDateAndTime = new MenuItem("Show Date/Time");
            showDateAndTime.addItemToMenu("Show Time");
            showDateAndTime.addItemToMenu("Show Date");
            MenuItem showVersionAndSpaces = new MenuItem("Version and Spaces");
            showVersionAndSpaces.addItemToMenu("Show Version");
            showVersionAndSpaces.addItemToMenu("Count Spaces");
            m_MainMenu.m_CurrentMenuItems.Add(showDateAndTime);
            m_MainMenu.m_CurrentMenuItems.Add(showVersionAndSpaces);
            m_MainMenu.Show();
        }
    }
}
