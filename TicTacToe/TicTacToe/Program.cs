using System;
using TicTacToe.Classes;

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


                switch(menuOptionSelected)
                {
                    case 1:
                        Console.Clear();
                        CreatePlayers();
                        PrintBoard();
                        break;
                    case 2:
                        Console.Clear();
                        Game.PrintAllWinningSolutions();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
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

        private static void CreatePlayers()
        {
            string chosenName = "";
            uint playerToSet = 1;
            bool inputIsValid = false;

            while (!inputIsValid && playerToSet <= 2)
            {
                inputIsValid = false;
                chosenName = "";

                Console.Clear();

                Console.Write($"\tHello Player {playerToSet}!\n\n Please enter your name: ");
                chosenName = Console.ReadLine();
                inputIsValid = VerifyNewPlayerName(chosenName);

                if (inputIsValid && playerToSet == 1)
                {
                    Player playerOne = new Player(chosenName, "X", false);
                    playerToSet++;
                    inputIsValid = false;
                }
                else if (inputIsValid && playerToSet == 2)
                {
                    Player playerTwo = new Player(chosenName, "O", false);
                    playerToSet++;
                }
            }

            Console.Clear();
        }

        public static bool VerifyNewPlayerName(string nameInput)
        {
            if (nameInput.Length == 0)
            {
                return false;
            }

            try
            {
                foreach (char c in nameInput.ToCharArray())
                {
                    if (!(c >= 65 && c <= 90) && !(c >= 97 && c <= 122))
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine($"Unable to create player with that name: {e.Message}");
                return false;
            }
        }

        public static void PrintBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"|{GameBoard.Board[i, j]}|");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }



    }
}
