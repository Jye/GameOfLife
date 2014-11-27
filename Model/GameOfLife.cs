using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GameOfLife
    {
        struct XY {
            public XY(int X, int Y)
            {
                this.X = X;
                this.Y = Y;
            }
            public int X;
            public int Y;
        }

        Boolean[,] cells;
        public int Rows { get; private set; }
        public int Columns { get; private set; }

        public GameOfLife(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            cells = new Boolean[rows,columns];
        }

        public bool IsCellAlive(int row, int column)
        {
            if (row >= 0 && column >= 0 
                && row < cells.GetLength(0) && column < cells.GetLength(1))
            {
                return cells[row, column];
            }
            else
            {
                return false;
            }
        }

        public void ToggleCell(int row, int column)
        {
            cells[row, column] = !IsCellAlive(row, column);
        }

        public void Step()
        {
            Boolean[,] nextStepCells = new Boolean[Rows,Columns];
            Array.Copy(cells, nextStepCells, cells.GetLength(0));

            for (int x = 0; x < cells.GetLength(0); x++)
            {
                for (int y = 0; y < cells.GetLength(1); y++)
                {
                    nextStepCells[x, y] = StepCell(x, y);
                }
            }
            cells = nextStepCells;
        }

        private IEnumerable<XY> GetNeighbours(int row, int column)
        {
            XY[] neighbours = new XY[] {
                new XY(row-1, column-1),
                new XY(row-1, column),
                new XY(row-1, column+1),
                new XY(row, column -1),
                new XY(row, column + 1),
                new XY(row+1, column-1),
                new XY(row+1, column),
                new XY(row+1, column+1)
            };
            return neighbours;
            
        }
        private Boolean StepCell(int row, int column) {

            int aliveNeighbours = 0;
            foreach(XY xy in GetNeighbours(row, column)) {
                if (IsCellAlive(xy.X, xy.Y))
                {
                    aliveNeighbours++;
                }
            }

            if (aliveNeighbours <= 1)
            {
                return false;
            }
            else if (aliveNeighbours == 3)
            {
                return true;
            }
            else
            {
                return IsCellAlive(row, column);
            }
            
        }

        public void Clear()
        {
            cells = new Boolean[Rows, Columns];
        }
    }
}
