using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuSolver.Strategies;
using SudokuSolver.Workers;

namespace SudokuSolver.test.unit
{
    [TestClass]
    public class NakedPairStrategyTest
    {
        private readonly ISudokuStrategy _nakedPairStrat = new NakedPairStrategy(new SudokuMapper());

        [TestMethod]
        public void ShouldEliminateNumbersInRowBasedOnNakedPair()
        {
            int[,] sudokuBoard = 
            {
                {1,2,34,5,34,6,7,348,9 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },

            };

            var solvedSudokuBoard = _nakedPairStrat.Solve(sudokuBoard);

            Assert.IsTrue(solvedSudokuBoard[0, 7] == 8);
        }

        [TestMethod]
        public void ShouldEliminateNumbersInColBasedOnNakedPair()
        {
            int[,] sudokuBoard =
            {
                {1,0,0,0,0,0,0,0,0 },
                {24,0,0,0,0,0,0,0,0 },
                {3,0,0,0,0,0,0,0,0 },
                {24,0,0,0,0,0,0,0,0 },
                {5,0,0,0,0,0,0,0,0 },
                {6,0,0,0,0,0,0,0,0 },
                {7,0,0,0,0,0,0,0,0 },
                {249,0,0,0,0,0,0,0,0 },
                {8,0,0,0,0,0,0,0,0 },

            };

            var solvedSudokuBoard = _nakedPairStrat.Solve(sudokuBoard);

            Assert.IsTrue(solvedSudokuBoard[7, 0] == 9);
        }

        [TestMethod]
        public void ShouldEliminateNumbersInBlockBasedOnNakedPair()
        {
            int[,] sudokuBoard =
            {
                {1,24,3,0,0,0,0,0,0 },
                {24,5,6,0,0,0,0,0,0 },
                {7,8,249,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },

            };

            var solvedSudokuBoard = _nakedPairStrat.Solve(sudokuBoard);

            Assert.IsTrue(solvedSudokuBoard[2, 2] == 9);
        }

        [TestMethod]
        public void ShouldEliminateNumbersInBlock5BasedOnNakedPair()
        {
            int[,] sudokuBoard =
            {
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,1,2,35,0,0,0 },
                {0,0,0,4,35,6,0,0,0 },
                {0,0,0,357,8,9,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },

            };

            var solvedSudokuBoard = _nakedPairStrat.Solve(sudokuBoard);

            Assert.IsTrue(solvedSudokuBoard[5, 3] == 7);
        }
        [TestMethod]
        public void ShouldEliminateNumbersInBlock9BasedOnNakedPair()
        {
            int[,] sudokuBoard =
            {
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,7,8,9 },
                {0,0,0,0,0,0,6,5,4 },
                {0,0,0,0,0,0,12,12,123 },

            };

            var solvedSudokuBoard = _nakedPairStrat.Solve(sudokuBoard);

            Assert.IsTrue(solvedSudokuBoard[8, 8] == 3);
        }
    }
}

