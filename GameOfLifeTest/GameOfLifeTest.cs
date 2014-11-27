using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLifeLogic;

namespace GameOfLifeTest
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
        public void AlternateShouldChangeCellFromLiveToDead()
        {
            GameOfLife model = new GameOfLife();
        }
    }
}
