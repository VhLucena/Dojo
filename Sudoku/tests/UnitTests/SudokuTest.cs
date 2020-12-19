using NUnit.Framework;

using SudokuDojo;

namespace Tests
{
    public class SudokuTest
    {
        private Sudoku sudoku;

        [SetUp]
        public void Setup()
        {
            sudoku = new Sudoku();
        }

        [Test]
        public void Test_InvalidLine()
        {
            var row = new int[9] { 1, 0, 0, 1, 0, 0, 0, 0, 0 };
                
            Assert.AreEqual(false, sudoku.IsLineValid(row));
        }

        [Test]
        public void Test_ValidLine()
        {
            var row = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            Assert.AreEqual(true, sudoku.IsLineValid(row));
        }

        [Test]
        public void Test_InvalidTable()
        {
            var state = new int[9, 9]
            {
                { 1, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            var table = new Table(state);

            Assert.AreEqual(false, sudoku.IsTableValid(table));
        }

        [Test]
        public void Test_ValidTable()
        {
            var table = new Table();

            Assert.AreEqual(true, sudoku.IsTableValid(table));
        }

    }
}