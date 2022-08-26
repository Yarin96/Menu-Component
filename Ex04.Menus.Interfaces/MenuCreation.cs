//namespace Ex04.Menus.Interfaces
//{
//    public class MenuCreation
//    {
//        private Interfaces.MainMenu m_MainMenu;

//        public MenuCreation(string i_MainMenuTitle)
//        {
//            m_MainMenu = new Interfaces.MainMenu(i_MainMenuTitle);
//        }

//        public void DefineAndRunMenu()
//        {
//            m_MainMenu.AddItemToMenu("Show Date/Time", 0);
//            m_MainMenu.AddItemToMenu("Version and Spaces", 0);
//            MainMenu showDateAndTime = new MainMenu("Show Date/Time", 1);
//            showDateAndTime.AddItemToMenu("Show time", 1);
//            showDateAndTime.AddItemToMenu("Show date", 1);
//            m_MainMenu.AddItemToMenu(showDateAndTime);

//            //m_MainMenu.AddItemToMenuAsSubMenu("Show Date/Time");
//            //m_MainMenu.AddItemToMenuAsSubMenu("Version and Spaces");
//            //m_MainMenu.AddItemToMenuAsMethod(menuItem1, menuItem3);
//            //m_MainMenu.AddItemToMenuAsMethod(menuItem1, menuItem4);
//            //m_MainMenu.AddItemToMenuAsMethod(menuItem2, menuItem5);
//            //m_MainMenu.AddItemToMenuAsMethod(menuItem2, menuItem6);
//            //m_MainMenu.Show();
//        }
//    }
//}
