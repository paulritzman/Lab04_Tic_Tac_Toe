using System;

namespace TicTacToe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintGreeting();

            string menuInput = "";
            uint menuOptionSelected;

            do
            {
                menuOptionSelected = 0;
                while (menuOptionSelected == 0)
                {
                    PrintMainMenu();
                    menuInput = Console.ReadLine();
                    menuOptionSelected = MainMenuSelection(menuInput);
                }


            } while (menuOptionSelected != 3);
        }
        // End of Main

        private static void PrintGreeting()
        {
            Console.WriteLine("\tWelcome to Tic-Tac-Toe!\n");
        }

        private static void PrintMainMenu()
        {
            Console.WriteLine(
                        "Please select an option below:\n" +
                        "1) Play Tic-Tac-Toe\n" +
                        "2) View all winning solutions\n" +
                        "3) Exit Application\n");
        }

        public static uint MainMenuSelection(string userMenuInput)
        {
            try
            {
                uint.TryParse(userMenuInput, out uint menuOption);

                if (menuOption >= 1 && menuOption <= 3)
                {
                    return menuOption;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Please input a valid menu option: {e.Message}");
                return 0;
            }

            return 0;
        }
    }
}
