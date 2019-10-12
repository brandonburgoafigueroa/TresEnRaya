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

        public bool AnyWins()
        {
            return GetWinner() != ' ';
        }
        public char GetWinner()
        {
            var values = Cells.Where(x=>x.IsNotEmpty()).Select(x => x.GetValue()).Distinct();
            foreach (var value in values)
            {
                var cells = Cells.Where(x => x.GetValue() == value);
                for (int i = 0; i < Size; i++)
                {
                    var cellsOfRow = cells.Where(x => x.X == i);
                    if (cellsOfRow.Count() == Size)
                    {
                        return value;
                    }
                }
                for (int i = 0; i < Size; i++)
                {
                    var cellsOfCols = cells.Where(x => x.Y == i);
                    if (cellsOfCols.Count() == Size)
                    {
                        return value;
                    }
                }
                var cellsOfFirstDiagonal = new List<Cell>();

               for (int i = 0; i < Size; i++)
               {
                    var cell = cells.SingleOrDefault(x=>x.X == i && x.Y == i);
                    if (cell != null)
                    {
                        cellsOfFirstDiagonal.Add(this[i, i]);
                    }
               }
                if (cellsOfFirstDiagonal.Count() == Size)
                {
                    return value;
                }
                var cellsOfSecondDiagonal = new List<Cell>();

                for (int i = 0; i < Size; i++)
                {
                    var cell = cells.SingleOrDefault(x => x.X == (Size-1)-i && x.Y == i);
                    if (cell != null)
                    {
                        cellsOfSecondDiagonal.Add(this[i, i]);
                    }
                }
                if (cellsOfSecondDiagonal.Count() == Size)
                {
                    return value;
                }

            }
            return ' ';
        }


        public void SetCell(Cell cell)
        {
            var targetCell = this[cell.X, cell.Y];
            targetCell.SetValue(cell.GetValue());
        }

    }
}
