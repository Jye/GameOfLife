using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace Tests
{
    [TestClass]
    public class GameOfLifeTest
    {
        [TestMethod]
        public void CellsShouldInitiallyBeDead()
        {
            GameOfLife model = new GameOfLife(2, 2);
            Assert.IsFalse(model.IsCellAlive(0, 0));
            Assert.IsFalse(model.IsCellAlive(0, 1));
            Assert.IsFalse(model.IsCellAlive(1, 0));
            Assert.IsFalse(model.IsCellAlive(1, 1));
        }

        [TestMethod]
        public void ToggleCellShouldMakeDeadCellAlive()
        {
            GameOfLife model = new GameOfLife(2, 2);
            Assert.IsFalse(model.IsCellAlive(0, 0));
            model.ToggleCell(0, 0);
            Assert.IsTrue(model.IsCellAlive(0, 0));
        }

        [TestMethod]
        public void ToggleCellShouldKillLiveCell()
        {
            GameOfLife model = new GameOfLife(2, 2);
            model.ToggleCell(1, 1);
            Assert.IsTrue(model.IsCellAlive(1, 1));
            model.ToggleCell(1, 1);
            Assert.IsFalse(model.IsCellAlive(1, 1));
        }

        [TestMethod]
        public void StepShouldKillCellsWithNoNeighbours()
        {
            GameOfLife model = new GameOfLife(3, 3);
            model.ToggleCell(1, 1);
            model.Step();
            Assert.IsFalse(model.IsCellAlive(1, 1));
        }

        [TestMethod]
        public void StepShouldKillCellsWithOneNeighbour()
        {
            GameOfLife model = new GameOfLife(3, 3);
            model.ToggleCell(1, 1);
            model.ToggleCell(1, 0);
            model.Step();
            Assert.IsFalse(model.IsCellAlive(1, 1));
        }

        [TestMethod]
        public void StepShouldBirthCellWithThreeNeighbours()
        {
            GameOfLife model = new GameOfLife(3, 3);
            model.ToggleCell(0, 1);
            model.ToggleCell(1, 1);
            model.ToggleCell(1, 0);
            model.Step();
            Assert.IsTrue(model.IsCellAlive(0, 0));
        }

    }
}
