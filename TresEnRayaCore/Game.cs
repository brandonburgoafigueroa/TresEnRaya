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

        public void Reset()
        {
            GC.SuppressFinalize(Board);
            Board = new Board();
        }

        public void Click(Cell cell)
        {
            char value = GetActualPlayer();
            cell.SetValue(value);
            Board.SetCell(cell);
        }

        private char GetActualPlayer()
        {
            return 'X';
        }

    }
}
