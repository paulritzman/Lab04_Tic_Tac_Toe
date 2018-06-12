using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Classes
{
    class Game
    {
        public static int[][] Winners = new int[][]
        {
            // horizontal
            new[] {1,2,3},
            new[] {4,5,6},
            new[] {7,8,9},

            // vertical
            new[] {1,4,7},
            new[] {2,5,8},
            new[] {3,6,9},

            // diagonal
            new[] {1,5,9},
            new[] {3,5,7},        
        };

        public static void PrintAllWinningSolutions()
        {
            string direction = "";

            Console.WriteLine("All Winning Solutions\n");

            for (int i = 0; i < Winners.Length; i++)
            {
                if (i == 0 || i == 3 || i == 6)
                {
                    direction = (i == 0) ? "horizontal" : (i == 3) ? "\nvertical" : "\ndiagonal";
                    Console.WriteLine(direction);
                }
                
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{Winners[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
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

        public static Player CreatePlayers(uint whichPlayerToSet, string marker)
        {
            string chosenName = "";
            bool inputIsValid = false;

            while (!inputIsValid)
            {
                inputIsValid = false;
                chosenName = "";

                Console.Clear();

                Console.Write($"\tHello Player {whichPlayerToSet}!\n\nPlease enter your name: ");
                chosenName = Console.ReadLine();
                inputIsValid = VerifyNewPlayerName(chosenName);

                if (inputIsValid)
                {
                    Player player = new Player(chosenName, marker, false);
                    return player;
                }
            }

            Console.Write("Unable to create player, try again.");
            return null;
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

        public static void PrintPlayerGreeting(Player playerOne, Player playerTwo)
        {
            Console.Clear();
            Console.Write(
                    $"Hello, {playerOne.Name} and {playerTwo.Name}! Ready to play?\n\n" +
                    $"Press any key to start Tic-Tac-Toe!");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
