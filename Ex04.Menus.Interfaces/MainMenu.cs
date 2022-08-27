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

        private static void exitProgram()
        {
            Console.Write("Press Enter to Exit...   ");
            Console.ReadLine();
        }

        public void Show()
        {
            try
            {
                do
                {
                    Console.Write(printMenu());
                    string userInput = Console.ReadLine();

                    if (userInput == "0")
                    {
                        break;
                    }

                    int userMenuChoice = InputValidations.CheckIfValidMenuChoice(userInput, m_CurrentMenuItems.Count);

                    if (m_CurrentMenuItems[userMenuChoice].m_IsItemMethod)
                    {
                        Console.Write(Environment.NewLine);
                        switch(m_CurrentMenuItems[userMenuChoice].m_MenuItemName)
                        {
                            case "Show Time":
                                Actions.showTime();
                                break;
                            case "Show Date":
                                Actions.showDate();
                                break;
                            case "Show Version":
                                Actions.showVersion();
                                break;
                            case "Count Spaces":
                                Actions.countSpaces();
                                break;
                        }

                        Console.WriteLine(Environment.NewLine + "Press enter to return..");
                        Console.ReadLine();
                        Console.Clear();
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
                string errorMessage = $"-> Error Message: {i_FormatException.Message}";
                Console.WriteLine(errorMessage);
                Console.ReadLine();
                Console.Clear();
                Show();
            }
            catch (ArgumentOutOfRangeException i_ArgumentOutOfRangeException)
            {
                string errorMessage =
                    $"-> Error Message: {i_ArgumentOutOfRangeException.ParamName} is out of the Menu options range. Press Enter to try again.";
                Console.WriteLine(errorMessage);
                Console.ReadLine();
                Console.Clear();
                Show();
            }
        }

        private string printMenu()
        {
            m_CurrentMenuDetailsMessage.Clear();
            string exitOrBackMessage = m_CurrentMenuTitle == "Interfaces Main Menu" ? "Exit" : "Back";
            m_CurrentMenuDetailsMessage.AppendLine($"**{m_CurrentMenuTitle}**");
            m_CurrentMenuDetailsMessage.AppendLine("----------------------------");

            for (int i = 0; i < m_CurrentMenuItems.Count; i++)
            {
                m_CurrentMenuDetailsMessage.AppendLine(string.Format(i + 1 + " -> " + m_CurrentMenuItems[i].m_MenuItemName));
            }

            m_CurrentMenuDetailsMessage.AppendLine($"0 -> {exitOrBackMessage}");
            m_CurrentMenuDetailsMessage.AppendLine("----------------------------");
            m_CurrentMenuDetailsMessage.AppendLine(
                $"Enter your request: (1 to {m_CurrentMenuItems.Count} or press '0' to {exitOrBackMessage}).");

            return m_CurrentMenuDetailsMessage.ToString();
        }
    }
}
