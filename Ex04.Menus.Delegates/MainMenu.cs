using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private readonly string r_RootMenuTitle;
        private readonly StringBuilder r_CurrentMenuDetailsMessage;
        private string m_CurrentMenuTitle;
        private string m_PrevMenuTitle;
        private List<MenuItem> m_PrevMenuItems;
        private List<MenuItem> m_CurrentMenuItems;

        public MainMenu(string i_MainMenuTitle)
        {
            r_RootMenuTitle = i_MainMenuTitle;
            m_CurrentMenuTitle = i_MainMenuTitle;
            m_CurrentMenuItems = new List<MenuItem>();
            m_PrevMenuItems = new List<MenuItem>();
            r_CurrentMenuDetailsMessage = new StringBuilder();
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

                    if (m_CurrentMenuItems[userMenuChoice].IsMenuItemMethod)
                    {
                        Console.Clear();
                        m_CurrentMenuItems[userMenuChoice].ActivateMenuItemMethod();
                        returnToMenu();
                    }
                    else
                    {
                        m_PrevMenuItems = m_CurrentMenuItems;
                        m_PrevMenuTitle = m_CurrentMenuTitle;
                        m_CurrentMenuTitle = m_CurrentMenuItems[userMenuChoice].MenuItemName;
                        m_CurrentMenuItems = m_CurrentMenuItems[userMenuChoice].MenuItems;
                        Console.Clear();
                    }
                }
                while (true);

                if (m_CurrentMenuTitle == r_RootMenuTitle)
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
                string errorMessage = string.Format("-> Error Message: {0} is out of the Menu options range. Press 'Enter' to try again.", i_ArgumentOutOfRangeException.ParamName);
                Console.WriteLine(errorMessage);
                Console.ReadLine();
                redrawMenu();
            }
        }

        private void drawMenu()
        {
            r_CurrentMenuDetailsMessage.Clear();
            string exitOrBackMessage = m_CurrentMenuTitle == r_RootMenuTitle ? "Exit" : "Back";
            r_CurrentMenuDetailsMessage.AppendLine(string.Format("**{0}**", m_CurrentMenuTitle));
            r_CurrentMenuDetailsMessage.AppendLine("----------------------------");

            for (int i = 0; i < m_CurrentMenuItems.Count; i++)
            {
                r_CurrentMenuDetailsMessage.AppendLine(string.Format(i + 1 + " -> " + m_CurrentMenuItems[i].MenuItemName));
            }

            r_CurrentMenuDetailsMessage.AppendLine(string.Format("0 -> {0}", exitOrBackMessage));
            r_CurrentMenuDetailsMessage.AppendLine("----------------------------");
            r_CurrentMenuDetailsMessage.AppendLine(string.Format("Enter your request: (1 to {0} or press '0' to {1}).", m_CurrentMenuItems.Count, exitOrBackMessage));

            Console.WriteLine(r_CurrentMenuDetailsMessage.ToString());
        }

        private void redrawMenu()
        {
            Console.Clear();
            Show();
        }

        private void returnToMenu()
        {
            Console.WriteLine(Environment.NewLine + "Press 'Enter' to return to menu...");
            Console.ReadLine();
            Console.Clear();
        }

        private void exitProgram()
        {
            Console.Write("Press 'Enter' to exit the program...");
            Console.ReadLine();
        }
    }
}