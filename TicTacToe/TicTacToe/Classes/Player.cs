using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Classes
{
    public class Player
    {
        public string Name { get; set; }
        public string Marker { get; set; }
        public bool IsTurn { get; set; }
        public int Positions { get; set; }

        public Player(string name, string marker, bool isTurn)
        {
            Name = name;
            Marker = marker;
            IsTurn = isTurn;
            Positions = 0;
        }
    }
}
