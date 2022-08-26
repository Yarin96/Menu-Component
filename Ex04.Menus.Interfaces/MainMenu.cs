using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private string m_CurrentMenuTitle;
        private string m_PrevMenuTitle;
        internal List<MenuItem> m_CurrentMenuItems;
        private List<MenuItem> m_PrevMenuItems;
        private StringBuilder m_CurrentMenuDetailsMessage;

        public MainMenu(string i_MainMenuTitle)
        {
            m_CurrentMenuTitle = i_MainMenuTitle;
            m_CurrentMenuItems = new List<MenuItem>();
            m_PrevMenuItems = new List<MenuItem>();
            m_CurrentMenuDetailsMessage = new StringBuilder();
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

                    userMenuChoice = InputValidations.CheckIfValidMenuChoice(userInput, m_CurrentMenuItems);

                    if (m_CurrentMenuItems[userMenuChoice].m_IsItemMethod)
                    {
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        m_PrevMenuItems = m_CurrentMenuItems;
                        m_PrevMenuTitle = m_CurrentMenuTitle;
                        m_CurrentMenuTitle = m_CurrentMenuItems[userMenuChoice].m_MenuItemName;
                        m_CurrentMenuItems = m_CurrentMenuItems[userMenuChoice].m_MenuItems;
                    }
                }
                while (true);

                if (m_CurrentMenuTitle == "Interfaces Main Menu")
                {
                    exitProgram();
                }
                else
                {
                    Console.Clear();
                    m_CurrentMenuItems = m_PrevMenuItems;
                    m_CurrentMenuTitle = m_PrevMenuTitle;
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

        private string printMenu()
        {
            m_CurrentMenuDetailsMessage.Clear();
            string exitOrBackMessage = m_CurrentMenuTitle == "Interfaces Main Menu" ? "Exit" : "Back";
            m_CurrentMenuDetailsMessage.AppendLine(string.Format("**{0}**", m_CurrentMenuTitle));
            m_CurrentMenuDetailsMessage.AppendLine("----------------------------");

            for (int i = 0; i < m_CurrentMenuItems.Count; i++)
            {
                m_CurrentMenuDetailsMessage.AppendLine(string.Format(i + 1 + " -> " + m_CurrentMenuItems[i].m_MenuItemName));
            }

            m_CurrentMenuDetailsMessage.AppendLine(string.Format("0 -> {0}", exitOrBackMessage));
            m_CurrentMenuDetailsMessage.AppendLine("----------------------------");
            m_CurrentMenuDetailsMessage.AppendLine(string.Format("Enter your request: (1 to {0} or press '0' to {1}).", m_CurrentMenuItems.Count, exitOrBackMessage));

            return m_CurrentMenuDetailsMessage.ToString();
        }

        private void exitProgram()
        {
            Console.Write("Press Enter to Exit...   ");
            Console.ReadLine();
        }
    }
}
