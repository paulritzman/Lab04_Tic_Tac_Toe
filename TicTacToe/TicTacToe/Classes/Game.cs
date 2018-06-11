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


    }
}
