using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TresEnRayaCore
{
    public class Board
    {
        private List<Cell> Cells;
        public Board()
        {
            BuildCells();
        }
        public int Size { get { return Cells.Select(x => x.X).Distinct().Count(); } }
        public bool HasAnyValue()
        {
            return Cells.Any(x => x.HasValue());
        }
        public Cell this[int x, int y] { get { return Cells.Single(z => z.X == x && z.Y == y); } }
        private void BuildCells()
        {
            Cells = new List<Cell>() {
                new Cell(){
                    X = 0,Y=0
                },
                new Cell(){
                    X = 0,Y=1
                },
                new Cell(){
                    X = 0,Y=2
                },
                new Cell(){
                    X = 1,Y=0
                },
                new Cell(){
                    X = 1,Y=1
                },
                new Cell(){
                    X = 1,Y=2
                },
                new Cell(){
                    X = 2,Y=0
                },
                new Cell(){
                    X = 2,Y=1
                },
                new Cell(){
                    X = 2,Y=2
                },
            };
        }
    }
}
