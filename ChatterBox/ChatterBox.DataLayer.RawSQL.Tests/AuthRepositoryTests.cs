using System;
using System.Collections.Generic;
using ChatterBox.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChatterBox.DataLayer.RawSQL.Tests
{
    [TestClass]
    public class AuthRepositoryTests
    {
        private const string ConnectionString = @"Data Source=DESKTOP-C09EP1V\SQLEXPRESS;Initial Catalog=MessengerBase;Integrated Security=True;";

        private readonly List<Guid> _tempUsers = new List<Guid>();

        [TestMethod]
        public void ShouldCheckExistanceOfLogin()
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
            var userRepository = new UsersRepository(ConnectionString);
            var userResult = userRepository.Create(user, login, password);
            _tempUsers.Add(userResult.Id);
            var authRepository = new AuthRepository(ConnectionString);
            var authResult = authRepository.Get(userResult.Id);

            //asserts
            Assert.AreEqual(authRepository.LoginExists(authResult.Login), true);
            Assert.AreEqual(authRepository.LoginExists("0"), false);
        }

        [TestMethod]
        public void ShouldCheckOppotunityOfSigningIn()
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
            var userRepository = new UsersRepository(ConnectionString);
            var userResult = userRepository.Create(user, login, password);
            _tempUsers.Add(userResult.Id);
            var authRepository = new AuthRepository(ConnectionString);

            //asserts
            Assert.AreEqual(authRepository.CanSignIn(login, password), true);
            Assert.AreEqual(authRepository.CanSignIn(login, password + "1"), false);
        }

        [TestMethod]
        public void ShouldCheckSigningIn()
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
            var userRepository = new UsersRepository(ConnectionString);
            var userResult = userRepository.Create(user, login, password);
            _tempUsers.Add(userResult.Id);
            var authRepository = new AuthRepository(ConnectionString);
            var userSignIn = authRepository.SignIn(login, password);

            //asserts
            Assert.AreEqual(userSignIn.Id, userResult.Id);
            Assert.AreEqual(userSignIn.Name, userResult.Name);
            Assert.AreEqual(userSignIn.LogInfo.Login, userResult.LogInfo.Login);
            Assert.AreEqual(userSignIn.LogInfo.Password, userResult.LogInfo.Password);
        }

        [TestCleanup]
        public void Clean()
        {
            foreach (var id in _tempUsers)
                new UsersRepository(ConnectionString).Delete(id);
        }
    }
}
