using System;
using System.Collections.Generic;
using System.Text;


namespace TicTacToe.Classes
{
    public class GameBoard
    {

        public static string[,] Board = new string[,]
        {
            { "1", "2", "3" },
            { "4", "5", "6" },
            { "7", "8", "9" },
        };

        public static void PrintBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"|{Board[i, j]}|");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

    }
}
