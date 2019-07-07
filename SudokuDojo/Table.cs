using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuDojo
{
    public class Table
    {
        public int[,] State;
        public readonly int Dimension;
        public readonly int BlockDimension;

        public Table()
        {
            Dimension = 9;
            BlockDimension = 3;
            State = new int[9, 9]
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
        }

        public Table(int[,] state)
        {
            Dimension = 9;
            BlockDimension = 3;
            State = state;
        }
    }
}
