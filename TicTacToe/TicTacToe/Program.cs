using System;
using TicTacToe.Classes;

namespace TicTacToe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintGreeting();
            LaunchMainMenu();
        }
        // End of Main

        private static void PrintGreeting()
        {
            Console.WriteLine("\tWelcome to Tic-Tac-Toe!\n");
        }

        private static void PrintMainMenuOptions()
        {
            Console.WriteLine(
                        "Please select an option below:\n" +
                        "1) Play Tic-Tac-Toe\n" +
                        "2) View all winning solutions\n" +
                        "3) Exit Application\n");
        }  

        public static void LaunchMainMenu()
        {
            string menuOptionSelected = "";

            do
            {
                menuOptionSelected = "";
                PrintMainMenuOptions();
                menuOptionSelected = Console.ReadLine();
                Console.Clear();

                switch (menuOptionSelected)
                {
                    case "1":
                        Game.PlayGame();
                        Console.Clear();
                        break;
                    case "2":
                        Game.PrintAllWinningSolutions();
                        Console.Write("\nPress any key to return to the main menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Your selection did not match one of the options below...\n");
                        break;
                }
            } while (menuOptionSelected != "3");
        }


    }
}
