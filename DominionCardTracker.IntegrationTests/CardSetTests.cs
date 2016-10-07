using DominionCardTracker.DataLayer.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionCardTracker.IntegrationTests
{
    [TestFixture]
    class CardSetTests
    {
        [Test]
        public void SelectAllTest()
        {
            var repo = new CardSetRepository();
            var results = repo.SelectAll();

            Assert.AreEqual(4, results.Count);
        }
    }
}
