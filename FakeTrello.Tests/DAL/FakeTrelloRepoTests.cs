using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeTrello.DAL;

namespace FakeTrello.Tests.DAL
{
    [TestClass]
    public class FakeTrelloRepoTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstanceOfRepo()
        {
            FakeTrelloRepository Repo = new FakeTrelloRepository();

            Assert.IsNotNull(Repo);
        }

        [TestMethod]
        public void EnsureIHaveNotNullContext()
        {
            FakeTrelloRepository Repo = new FakeTrelloRepository();

            Assert.IsNotNull(Repo.Context);
        }

        [TestMethod]
        public void EnsureICanInjectContextInstance()
        {
            FakeTrelloContext context = new FakeTrelloContext();
            FakeTrelloRepository repo = new FakeTrelloRepository(context);

            Assert.IsNotNull(repo.Context);
        }
    }
}
