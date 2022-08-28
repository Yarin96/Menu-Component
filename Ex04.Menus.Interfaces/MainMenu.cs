using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private string m_CurrentMenuTitle;
        private string m_PrevMenuTitle;
        private StringBuilder m_CurrentMenuDetailsMessage;
        private List<MenuItem> m_PrevMenuItems;
        private List<MenuItem> m_CurrentMenuItems;

        public MainMenu(string i_MainMenuTitle)
        {
            m_CurrentMenuTitle = i_MainMenuTitle;
            m_CurrentMenuItems = new List<MenuItem>();
            m_PrevMenuItems = new List<MenuItem>();
            m_CurrentMenuDetailsMessage = new StringBuilder();
        }

        public void AddMenuItemToMainMenu(MenuItem i_MenuItem)
        {
            m_CurrentMenuItems.Add(i_MenuItem);
        }

        public void Show()
        {
            try
            {
                string userInput = string.Empty;
                int userMenuChoice = 0;

                do
                {
                    drawMenu();
                    userInput = Console.ReadLine();

                    if (userInput == "0")
                    {
                        break;
                    }

                    userMenuChoice = InputValidations.CheckIfValidMenuChoice(userInput, m_CurrentMenuItems.Count);

                    if (m_CurrentMenuItems[userMenuChoice].IsItemMethod)
                    {
                        Console.Clear();
                        m_CurrentMenuItems[userMenuChoice].ActivateMethod();
                        Console.WriteLine(Environment.NewLine + "Press 'Enter' to return...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        m_PrevMenuItems = m_CurrentMenuItems;
                        m_PrevMenuTitle = m_CurrentMenuTitle;
                        m_CurrentMenuTitle = m_CurrentMenuItems[userMenuChoice].MenuItemName;
                        m_CurrentMenuItems = m_CurrentMenuItems[userMenuChoice].MenuItems;
                    }
                }
                while (true);

                if (m_CurrentMenuTitle == "Interfaces Main Menu")
                {
                    exitProgram();
                }
                else
                {
                    m_CurrentMenuItems = m_PrevMenuItems;
                    m_CurrentMenuTitle = m_PrevMenuTitle;
                    redrawMenu();
                }
            }
            catch (FormatException i_FormatException)
            {
                string errorMessage = string.Format("-> Error Message: {0}", i_FormatException.Message);
                Console.WriteLine(errorMessage);
                Console.ReadLine();
                redrawMenu();
            }
            catch (ArgumentOutOfRangeException i_ArgumentOutOfRangeException)
            {
                string errorMessage = string.Format("-> Error Message: {0} is out of the Menu options range. Press Enter to try again.", i_ArgumentOutOfRangeException.ParamName);
                Console.WriteLine(errorMessage);
                Console.ReadLine();
                redrawMenu();
            }
        }

        private void drawMenu()
        {
            m_CurrentMenuDetailsMessage.Clear();
            string exitOrBackMessage = m_CurrentMenuTitle == "Interfaces Main Menu" ? "Exit" : "Back";
            m_CurrentMenuDetailsMessage.AppendLine(string.Format("**{0}**", m_CurrentMenuTitle));
            m_CurrentMenuDetailsMessage.AppendLine("----------------------------");

            for (int i = 0; i < m_CurrentMenuItems.Count; i++)
            {
                m_CurrentMenuDetailsMessage.AppendLine(string.Format(i + 1 + " -> " + m_CurrentMenuItems[i].MenuItemName));
            }

            m_CurrentMenuDetailsMessage.AppendLine($"0 -> {exitOrBackMessage}");
            m_CurrentMenuDetailsMessage.AppendLine("----------------------------");
            m_CurrentMenuDetailsMessage.AppendLine(string.Format("Enter your request: (1 to {0} or press '0' to {1}).", m_CurrentMenuItems.Count, exitOrBackMessage));

            Console.WriteLine(m_CurrentMenuDetailsMessage.ToString());
        }

        private void redrawMenu()
        {
            Console.Clear();
            Show();
        }

        private void exitProgram()
        {
            Console.Write("Press 'Enter' to exit the program...");
            Console.ReadLine();
        }
    }
}
