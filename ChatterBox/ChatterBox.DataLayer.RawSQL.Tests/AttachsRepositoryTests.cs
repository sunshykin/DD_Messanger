using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChatterBox.DataLayer.RawSQL.Tests
{
    [TestClass]
    public class AttachsRepositoryTests
    {
        private const string ConnectionString = @"Data Source=DESKTOP-C09EP1V\SQLEXPRESS;Initial Catalog=MessengerBase;Integrated Security=True;";
        
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
