using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChatterBox.DataLayer.RawSQL.Tests
{
    [TestClass]
    public class AttachsRepositoryTests
    {
        private readonly string ConnectionString;

        public AttachsRepositoryTests()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["ChatterBase"].ConnectionString;
        }

        [TestMethod]
        public void ShouldCheckExistanceOfAttach()
        {
            //act
            var attachRepository = new AttachsRepository(ConnectionString);

            //assert
            Assert.AreEqual(attachRepository.AttachExists(Guid.Empty), false);
        }

        [TestCleanup]
        public void Clean()
        {
        }
    }
}
