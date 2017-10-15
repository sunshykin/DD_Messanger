using System;
using System.Collections.Generic;
using System.Linq;
using ChatterBox.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChatterBox.DataLayer.RawSQL.Tests
{
    [TestClass]
    public class UsersRepositoryTests
    {
        private const string ConnectionString = @"Data Source=DESKTOP-C09EP1V\SQLEXPRESS;Initial Catalog=MessengerBase;Integrated Security=True;";

        private readonly List<Guid> _tempUsers = new List<Guid>();
        private readonly List<Guid> _tempChats = new List<Guid>();

        [TestMethod]
        public void ShouldCreateUser()
        {
            //arrange
            var user = new User
            {
                Name = "testUser",
                Picture = "\\pic\\temp.jpg"
            };
            var login = "testUser";
            var password = "qwerty123";

            //act
            var repository = new UsersRepository(ConnectionString);
            var result = repository.Create(user, login, password);
            _tempUsers.Add(result.Id);

            //asserts
            Assert.AreEqual(result.Name, user.Name);
            Assert.AreEqual(result.Picture, user.Picture);
            Assert.AreEqual(result.LogInfo.Login, login);
            Assert.AreEqual(result.LogInfo.Password, AuthRepository.GetHashString(password));
        }

        [TestMethod]
        public void ShouldCreateAndDeleteUser()
        {
            //arrange
            var user = new User
            {
                Name = "testUser",
                Picture = "\\pic\\temp.jpg"
            };
            var login = "testUser";
            var password = "qwerty123";

            //act
            var repository = new UsersRepository(ConnectionString);

            repository.Create(user, login, password);
            repository.Delete(user.Id);

            //asserts
            Assert.AreEqual(repository.UserExists(user.Id), false);
            Assert.AreEqual(new AuthRepository(ConnectionString).LoginExists(login), false);
        }

        [TestMethod]
        public void ShouldGetUser()
        {
            //arrange
            var user = new User
            {
                Name = "testUser",
                Picture = "\\pic\\temp.jpg"
            };
            var login = "testUser";
            var password = "qwerty123";

            //act
            var repository = new UsersRepository(ConnectionString);
            var result = repository.Create(user, login, password);
            _tempUsers.Add(result.Id);
            result = repository.Get(result.Id);

            //asserts
            Assert.AreEqual(result.Name, user.Name);
            Assert.AreEqual(result.Picture, user.Picture);
            Assert.AreEqual(result.LogInfo.Login,login);
            Assert.AreEqual(result.LogInfo.Password, AuthRepository.GetHashString(password));
        }

        [TestMethod]
        public void ShouldCheckExistanceOfUser()
        {
            //arrange
            Guid empty = Guid.Empty;
            Guid newid = Guid.NewGuid();

            //act
            var repository = new UsersRepository(ConnectionString);

            //asserts
            Assert.AreEqual(repository.UserExists(empty), false);
            Assert.AreEqual(repository.UserExists(newid), false);
        }

        [TestMethod]
        public void ShouldChangeLoginOfUser()
        {
            //arrange
            var user = new User
            {
                Name = "testUser",
                Picture = "\\pic\\temp.jpg"
            };
            var login = "testUser";
            var password = "qwerty123";

            //act
            var repository = new UsersRepository(ConnectionString);
            var result = repository.Create(user, login, password);
            _tempUsers.Add(result.Id);
            repository.ChangeLogin(result.Id, "newLogin", password);
            result = repository.Get(result.Id);

            //asserts
            Assert.AreEqual(result.LogInfo.Login, "newLogin");
        }

        [TestMethod]
        public void ShouldChangePasswordOfUser()
        {
            //arrange
            var user = new User
            {
                Name = "testUser",
                Picture = "\\pic\\temp.jpg"
            };
            var login = "testUser";
            var password = "qwerty123";

            //act
            var repository = new UsersRepository(ConnectionString);
            var result = repository.Create(user, login, password);
            _tempUsers.Add(result.Id);
            repository.ChangePassword(result.Id, password, "newPassword");
            result = repository.Get(result.Id);

            //asserts
            Assert.AreEqual(result.LogInfo.Password, AuthRepository.GetHashString("newPassword"));
        }

        [TestMethod]
        public void ShouldGetChatsOfUser()
        {
            //arrange
            var user = new User
            {
                Name = "testUser",
                Picture = "\\pic\\temp.jpg"
            };
            var login = "testUser1";
            var password = "qwerty123";

            //act
            var userRepository = new UsersRepository(ConnectionString);
            var resultUser = userRepository.Create(user, login, password);
            _tempUsers.Add(resultUser.Id);
            var chatRepository = new ChatsRepository(ConnectionString);
            var chatResult = chatRepository.Create("chatTitle", new List<Guid>() {resultUser.Id});
            _tempChats.Add(chatResult.Id);
            var chats = userRepository.GetUserChats(resultUser.Id);

            //asserts
            Assert.AreEqual(chats.Count(), 1);
        }

        [TestCleanup]
        public void Clean()
        {
            foreach (var id in _tempChats)
                new ChatsRepository(ConnectionString).Delete(id);
            foreach (var id in _tempUsers)
                new UsersRepository(ConnectionString).Delete(id);
        }
    }
}
