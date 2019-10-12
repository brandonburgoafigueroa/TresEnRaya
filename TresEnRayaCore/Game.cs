using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TresEnRayaCore
{
    public class Game
    {
        private Board Board;
        private Player Human;
        private Player IA;
        public Game()
        {
            Board = new Board();
            BuildPlayers();
        }
        public bool IsStarted()
        {
            return Board.HasAnyValue();
        }
        private void BuildPlayers()
        {
            Human = new Player() { Indicator = 'X' };
            IA = new Player() { Indicator = '0' };
        }
        public Board GetBoard()
        {
            return Board;
        }

       
    }
}
