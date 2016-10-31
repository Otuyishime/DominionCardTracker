using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DominionCardTracker.DataLayer.Repositories;

namespace DominionCardTracker.Test
{
    [TestClass]
    public class CardSetTests
    {
        [TestMethod]
        public void Test_SelectAll()
        {
            // Arrange
            int expected = 4;

            // Act
            CardSetRepository crdStRepo = new CardSetRepository();
            int actual = crdStRepo.SelectAll().Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
