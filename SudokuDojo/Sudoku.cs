using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuDojo
{
    public class Sudoku
    {
        public bool IsTableValid(Table table)
        {
            return AreBlocksValid(table) && AreColumnsValid(table) && AreRowsValid(table);
        }

        public bool AreBlocksValid(Table table)
        {
            for (int row = 0; row < table.Dimension; row+=table.BlockDimension)
            {
                for (int column = 0; column < table.Dimension; column += table.BlockDimension)
                {
                    if (!IsLineValid(SliceBlock(table, row, column)))
                    {
                        return false;
                    }
                }
                    
            }
            return true;
        }

        public bool AreRowsValid(Table table)
        {
            for(int row = 0; row < table.Dimension; row++)
            {
                if (!IsLineValid(SliceRow(table, row)))
                {
                    return false;
                }
            }
            return true;
        }

        public bool AreColumnsValid(Table table)
        {
            for (int column = 0; column < table.Dimension; column++)
            {
                if (!IsLineValid(SliceColumn(table, column)))
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsLineValid(int[] line)
        {
            var foundNumbers = new List<int>();

            for (int index = 0; index < line.Length; index++)
            {
                int current = line[index];
                if (current != 0)
                {
                    if (foundNumbers.Contains(current))
                    {
                        return false;
                    }
                    foundNumbers.Add(current);
                }
            }

            return true;
        }

        private int[] SliceRow(Table table, int index)
        {
            int[] result = new int[table.Dimension];

            for (var i = 0; i < table.State.GetLength(0); i++)
            {
                result[i] = table.State[index, i];
            }

            return result;
        }

        private int[] SliceColumn(Table table, int index)
        {
            int[] result = new int[table.Dimension];

            for (var i = 0; i < table.State.GetLength(0); i++)
            {
                result[i] = table.State[i, index];
            }

            return result;
        }

        private int[] SliceBlock(Table table, int row, int column)
        {
            int[] result = new int[table.Dimension];
            int k = 0;

            for (var i = row; i < row+table.BlockDimension; i++)
            {
                for (var j = column; j < column+table.BlockDimension; j++)
                {
                    result[k++] = table.State[i,j];
                }
            }

            return result;
        }
    }
}
