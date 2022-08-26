using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private string m_MainMenuTitle;
        private string m_PrevMenuTitle;
        private List<MenuItem> m_MenuItems;
        private List<MenuItem> m_PrevMenuItems;
        private StringBuilder m_CurrentMenuDetails = new StringBuilder();

        public MainMenu(string i_MainMenuTitle, int i_MenuItemLevel)
        {
               m_MenuItems = new List<MenuItem>();
               m_PrevMenuItems = new List<MenuItem>();
               m_MainMenuTitle = i_MainMenuTitle;
        }

        public void DefineAndRunMenu()
        {
            MenuItem showDateAndTime = new MenuItem("Show Date/Time");
            showDateAndTime.addItemToMenu("Show Time");
            showDateAndTime.addItemToMenu("Show Date");
            MenuItem showVersionAndSpaces = new MenuItem("Version and Spaces");
            showVersionAndSpaces.addItemToMenu("Show Version");
            showVersionAndSpaces.addItemToMenu("Count Spaces");
            m_MenuItems.Add(showDateAndTime);
            m_MenuItems.Add(showVersionAndSpaces);
            Show();
        }

        public void Show()
        {
            try
            {
                string userInput = string.Empty;
                int userMenuChoice = 0;

                do
                {
                    Console.WriteLine(printMenu());
                    userInput = Console.ReadLine();

                    if (userInput == "0")
                    {
                        break;
                    }

                    userMenuChoice = InputValidations.CheckIfValidMenuChoice(userInput, m_MenuItems);

                    if (m_MenuItems[userMenuChoice].m_IsItemMethod)
                    {
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        m_PrevMenuItems = m_MenuItems;
                        m_PrevMenuTitle = m_MainMenuTitle;
                        m_MainMenuTitle = m_MenuItems[userMenuChoice].m_MenuItemName;
                        m_MenuItems = m_MenuItems[userMenuChoice].m_MenuItems;
                    }
                }
                while (true);

                if (m_MainMenuTitle == "Interfaces Main Menu")
                {
                    exitProgram();
                }
                else
                {
                    Console.Clear();
                    m_MenuItems = m_PrevMenuItems;
                    m_MainMenuTitle = m_PrevMenuTitle;
                    Show();
                }
            }
            catch (FormatException i_FormatException)
            {
                string errorMessage = string.Format(
                    "-> Error Message: {0}",
                    i_FormatException.Message);
                Console.WriteLine(errorMessage);
            }
            catch (ArgumentOutOfRangeException i_ArgumentOutOfRangeException)
            {
                string errorMessage = string.Format(
                    "-> Error Message: {0}",
                    i_ArgumentOutOfRangeException.Message);
                Console.WriteLine(errorMessage);
            }
        }

        public string printMenu()
        {
            m_CurrentMenuDetails.Clear();
            string exitOrBackMessage = m_MainMenuTitle == "Interfaces Main Menu" ? "Exit" : "Back";
            m_CurrentMenuDetails.AppendLine(string.Format("**{0}**", m_MainMenuTitle));
            m_CurrentMenuDetails.AppendLine("--------------------");

            for (int i = 0; i < m_MenuItems.Count; i++)
            {
                m_CurrentMenuDetails.AppendLine(string.Format(i + 1 + " -> " + m_MenuItems[i].m_MenuItemName));
            }

            m_CurrentMenuDetails.AppendLine(string.Format("0 -> {0}", exitOrBackMessage));
            m_CurrentMenuDetails.AppendLine("--------------------");
            m_CurrentMenuDetails.AppendLine(string.Format("Enter your request: (1 to {0} or press '0' to {1}).", m_MenuItems.Count, exitOrBackMessage));

            return m_CurrentMenuDetails.ToString();
        }

        private void exitProgram()
        {
            Console.Write("Press Enter to Exit...   ");
            Console.ReadLine();
        }
    }
}
