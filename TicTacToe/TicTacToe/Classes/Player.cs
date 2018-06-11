using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Classes
{
    public class Player
    {
        public Player(string _name, string _marker, bool _isTurn)
        {
            string name = _name;
            string marker = _marker;
            bool isTurn = _isTurn; // need to make logic for this
        }

        public static void CreateNewPlayer(int playerNumber)
        {
            string newPlayerName = "";
            bool playerNameIsValid = false;

            while (playerNameIsValid == false)
            {
                Console.Clear();

                Console.Write($"Player {playerNumber}, enter your name: ");

                newPlayerName = Console.ReadLine();
                playerNameIsValid = VerifyNewPlayerName(newPlayerName);
            }

            Player player1 = (playerNumber == 1) ? new Player(newPlayerName, "X") : new Player(newPlayerName, "O");
            Console.WriteLine();
        }

        private static bool VerifyNewPlayerName(string nameInput)
        {
            if (nameInput.Length == 0) {
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

                    return true;
                }
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine($"Unable to create player with that name: {e.Message}");
                return false;
            }

            return false;
        }



    }
}
