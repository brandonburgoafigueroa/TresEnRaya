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
            Human = new Player() { Indicator = 'X' , IsCurrent = true};
            IA = new Player() { Indicator = '0' ,IsCurrent = false};
        }

        public Board GetBoard()
        {
            return Board;
        }
        public bool AnyWins()
        {
            return Board.AnyWins();
        }
        public Player GetWinner()
        {
            char value = Board.GetWinner();
            return Human.Indicator == value ? Human : IA;
        }
        public void Reset()
        {
            GC.SuppressFinalize(Board);
            Board = new Board();
        }
        public Player GetCurrentPlayer()
        {
            return Human.IsCurrent ? Human : IA;
        }
        public void Click(Cell cell)
        {
            char value = GetActualPlayer();
            cell.SetValue(value);
            Board.SetCell(cell);
            ChangeTurn();
        }
        private void ChangeTurn()
        {
            Human.AlternateTurn();
            IA.AlternateTurn();
        }
        private char GetActualPlayer()
        {
            return Human.IsCurrent ? Human.Indicator : IA.Indicator;
        }

    }
}
