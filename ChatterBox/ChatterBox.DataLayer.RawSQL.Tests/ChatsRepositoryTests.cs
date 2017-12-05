using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using ChatterBox.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChatterBox.DataLayer.RawSQL.Tests
{
    [TestClass]
    public class ChatsRepositoryTests
    {
        private readonly string ConnectionString;

        private readonly List<Guid> _tempUsers = new List<Guid>();
        private readonly List<Guid> _tempChats = new List<Guid>();
        private readonly List<Guid> _tempMessages = new List<Guid>();
        
        public ChatsRepositoryTests()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["ChatterBase"].ConnectionString;
        }

        [TestMethod]
        public void ShouldCreateChat()
        {
            //arrange
            var user = new User
            {
                Name = "testCharUser",
                Picture = new byte[] { }
            };
            var login = "testCharUser";
            var password = "qwerty123";
            var title = "chatTitle";

            //act
            var userRepository = new UsersRepository(ConnectionString);
            var resultUser1 = userRepository.Create(user, login, password);
            var resultUser2 = userRepository.Create(user, login + "1", password);
            var userIds = new List<Guid> { resultUser1.Id, resultUser2.Id};
            _tempUsers.AddRange(userIds);
            var chatRepository = new ChatsRepository(ConnectionString);
            var resultChat = chatRepository.Create(title, userIds);
            _tempChats.Add(resultChat.Id);

            //asserts
            Assert.AreEqual(resultChat.Title, title);
            Assert.AreEqual(resultChat.Members.Count(), 2);
            Assert.AreEqual(resultChat.Members.Any(u => u.Id == resultUser1.Id), true);
            Assert.AreEqual(resultChat.Members.Any(u => u.Id == resultUser2.Id), true);
        }

        [TestMethod]
        public void ShouldCreateAndDeleteChat()
        {

            //arrange
            var user = new User
            {
                Name = "testCharUser",
                Picture = new byte[] { }
            };
            var login = "testCharUser";
            var password = "qwerty123";
            var title = "chatTitle";

            //act
            var userRepository = new UsersRepository(ConnectionString);
            var resultUser1 = userRepository.Create(user, login, password);
            var resultUser2 = userRepository.Create(user, login + "1", password);
            var userIds = new List<Guid> { resultUser1.Id, resultUser2.Id };
            _tempUsers.AddRange(userIds);
            var chatRepository = new ChatsRepository(ConnectionString);
            var resultChat = chatRepository.Create(title, userIds);
            chatRepository.Delete(resultChat.Id);

            //asserts
            Assert.AreEqual(chatRepository.ChatExists(resultChat.Id), false);
        }

        [TestMethod]
        public void ShouldGetChat()
        {
            //arrange
            var user = new User
            {
                Name = "testCharUser",
                Picture = new byte[] { }
            };
            var login = "testCharUser";
            var password = "qwerty123";
            var title = "chatTitle";
            var pic = new byte[] {};

            //act
            var userRepository = new UsersRepository(ConnectionString);
            var resultUser1 = userRepository.Create(user, login, password);
            var resultUser2 = userRepository.Create(user, login + "1", password);
            var userIds = new List<Guid> { resultUser1.Id, resultUser2.Id };
            _tempUsers.AddRange(userIds);
            var chatRepository = new ChatsRepository(ConnectionString);
            var tempChat = chatRepository.Create(title, userIds, pic);
            var resultChat = chatRepository.Get(tempChat.Id);
            _tempChats.Add(resultChat.Id);

            //asserts
            Assert.AreEqual(resultChat.Title, title);
            Assert.AreEqual(resultChat.Members.Count(), 2);
            Assert.AreEqual(resultChat.Members.Any(u => u.Id == resultUser1.Id), true);
            Assert.AreEqual(resultChat.Members.Any(u => u.Id == resultUser2.Id), true);
        }

        [TestMethod]
        public void ShouldCheckExistanceOfChat()
        {
            //arrange
            var user = new User
            {
                Name = "testCharUser",
                Picture = new byte[] { }
            };
            var login = "testCharUser";
            var password = "qwerty123";
            var title = "chatTitle";
            var pic = new byte[] {};

            //act
            var userRepository = new UsersRepository(ConnectionString);
            var resultUser1 = userRepository.Create(user, login, password);
            var resultUser2 = userRepository.Create(user, login + "1", password);
            var userIds = new List<Guid> { resultUser1.Id, resultUser2.Id };
            _tempUsers.AddRange(userIds);
            var chatRepository = new ChatsRepository(ConnectionString);
            var resultChat = chatRepository.Create(title, userIds, pic);
            _tempChats.Add(resultChat.Id);

            //asserts
            Assert.AreEqual(chatRepository.ChatExists(resultChat.Id), true);
            Assert.AreEqual(chatRepository.ChatExists(Guid.Empty), false);
        }

        [TestMethod]
        public void ShouldGetChatUsers()
        {
            //arrange
            var user = new User
            {
                Name = "testCharUser",
                Picture = new byte[] { }
            };
            var login = "testCharUser";
            var password = "qwerty123";
            var title = "chatTitle";
            var pic = new byte[] {};

            //act
            var userRepository = new UsersRepository(ConnectionString);
            var resultUser1 = userRepository.Create(user, login, password);
            var resultUser2 = userRepository.Create(user, login + "1", password);
            var userIds = new List<Guid> { resultUser1.Id, resultUser2.Id };
            _tempUsers.AddRange(userIds);
            var chatRepository = new ChatsRepository(ConnectionString);
            var resultChat = chatRepository.Create(title, userIds, pic);
            _tempChats.Add(resultChat.Id);
            var resultUsers = chatRepository.GetChatUsers(resultChat.Id);

            //asserts
            Assert.AreEqual(resultUsers.Any(u => u.Id == resultUser1.Id && u.Name ==
                resultUser1.Name && u.LogInfo.Login == resultUser1.LogInfo.Login), true);
            Assert.AreEqual(resultUsers.Any(u => u.Id == resultUser2.Id && u.Name ==
                resultUser2.Name && u.LogInfo.Login == resultUser2.LogInfo.Login), true);
            Assert.AreEqual(resultUsers.Count(), 2);
        }

        /*[TestMethod]
        public void ShouldGetChatAttachs()
        {
            //arrange
            var user = new User
            {
                Name = "testCharUser",
                Picture = new byte[] { }
            };
            var login = "testCharUser";
            var password = "qwerty123";
            var title = "chatTitle";
            var pic = new byte[] {};
            var atch1 = new List<string>() {"pic.jpg", "text.txt"};
            var atch2 = new List<string>() {"pic.png", "music.mp3"};
            string msg1 = "TestText of msg";
            string msg2 = "TestText of msg2";

            //act
            var userRepository = new UsersRepository(ConnectionString);
            var resultUser1 = userRepository.Create(user, login, password);
            var resultUser2 = userRepository.Create(user, login + "1", password);
            var userIds = new List<Guid> { resultUser1.Id, resultUser2.Id };
            _tempUsers.AddRange(userIds);
            var chatRepository = new ChatsRepository(ConnectionString);
            var resultChat = chatRepository.Create(title, userIds, pic);
            _tempChats.Add(resultChat.Id);
            var messageRepository = new MessagesRepository(ConnectionString);
            var resultMsg1 = messageRepository.Send(msg1, resultUser1.Id, resultChat.Id, atch1);
            var resultMsg2 = messageRepository.Send(msg2, resultUser2.Id, resultChat.Id, atch2);
            var resultAttachs = chatRepository.GetChatAttachs(resultChat.Id);
            _tempMessages.AddRange(new List<Guid> {resultMsg1.Id, resultMsg2.Id});

            //asserts
            Assert.AreEqual(resultAttachs.Any(a => a.Path == "pic.jpg" && a.Sender.Id == resultUser1.Id), true);
            Assert.AreEqual(resultAttachs.Any(a => a.Path == "text.txt" && a.Sender.Id == resultUser1.Id), true);
            Assert.AreEqual(resultAttachs.Any(a => a.Path == "pic.png" && a.Sender.Id == resultUser2.Id), true);
            Assert.AreEqual(resultAttachs.Any(a => a.Path == "music.mp3" && a.Sender.Id == resultUser2.Id), true);
        }*/

        [TestMethod]
        public void ShouldGetChatMessages()
        {
            //arrange
            var user = new User
            {
                Name = "testCharUser",
                Picture = new byte[] { }
            };
            var login = "testCharUser";
            var password = "qwerty123";
            var title = "chatTitle";
            var pic = new byte[] {};
            string msg1 = "TestText of msg";
            string msg2 = "TestText of msg2";

            //act
            var userRepository = new UsersRepository(ConnectionString);
            var resultUser1 = userRepository.Create(user, login, password);
            var resultUser2 = userRepository.Create(user, login + "1", password);
            var userIds = new List<Guid> { resultUser1.Id, resultUser2.Id };
            _tempUsers.AddRange(userIds);
            var chatRepository = new ChatsRepository(ConnectionString);
            var resultChat = chatRepository.Create(title, userIds, pic);
            _tempChats.Add(resultChat.Id);
            var messageRepository = new MessagesRepository(ConnectionString);
            var resultMsg1 = messageRepository.Send(msg1, resultUser1.Id, resultChat.Id);
            var resultMsg2 = messageRepository.Send(msg2, resultUser2.Id, resultChat.Id);
            var resultMessages = chatRepository.GetChatMessages(resultChat.Id);
            _tempMessages.AddRange(new List<Guid> { resultMsg1.Id, resultMsg2.Id });

            //asserts
            Assert.AreEqual(resultMessages.Any(a => a.Text == msg1 && a.Sender.Id == resultUser1.Id), true);
            Assert.AreEqual(resultMessages.Any(a => a.Text == msg2 && a.Sender.Id == resultUser2.Id), true);
        }

        [TestMethod]
        public void ShouldChangeChatTitle()
        {
            //arrange
            var user = new User
            {
                Name = "testCharUser",
                Picture = new byte[] { }
            };
            var login = "testCharUser";
            var password = "qwerty123";
            var title = "chatTitle";
            var newTitle = "newTitleOfChat";

            //act
            var userRepository = new UsersRepository(ConnectionString);
            var resultUser1 = userRepository.Create(user, login, password);
            var resultUser2 = userRepository.Create(user, login + "1", password);
            var userIds = new List<Guid> { resultUser1.Id, resultUser2.Id };
            _tempUsers.AddRange(userIds);
            var chatRepository = new ChatsRepository(ConnectionString);
            var resultChat = chatRepository.Create(title, userIds);
            _tempChats.Add(resultChat.Id);
            chatRepository.ChangeTitle(resultChat.Id, newTitle);
            resultChat = chatRepository.Get(resultChat.Id);

            //asserts
            Assert.AreEqual(newTitle, resultChat.Title);
        }

        [TestMethod]
        public void ShouldChangeChatPicture()
        {
            //arrange
            var user = new User
            {
                Name = "testCharUser",
                Picture = new byte[] { }
            };
            var login = "testCharUser";
            var password = "qwerty123";
            var title = "chatTitle";
            var pic = new byte[] { };
            var newPic = new byte[] { };

            //act
            var userRepository = new UsersRepository(ConnectionString);
            var resultUser1 = userRepository.Create(user, login, password);
            var resultUser2 = userRepository.Create(user, login + "1", password);
            var userIds = new List<Guid> { resultUser1.Id, resultUser2.Id };
            _tempUsers.AddRange(userIds);
            var chatRepository = new ChatsRepository(ConnectionString);
            var resultChat = chatRepository.Create(title, userIds, pic);
            _tempChats.Add(resultChat.Id);
            chatRepository.ChangePicture(resultChat.Id, newPic);
            resultChat = chatRepository.Get(resultChat.Id);

            //asserts
            Assert.AreEqual(newPic, resultChat.Picture);
        }

        [TestMethod]
        public void ShouldAddMembersToChat()
        {
            //arrange
            var user = new User
            {
                Name = "testCharUser",
                Picture = new byte[] { }
            };
            var login = "testCharUser";
            var password = "qwerty123";
            var title = "chatTitle";

            //act
            var userRepository = new UsersRepository(ConnectionString);
            var resultUser1 = userRepository.Create(user, login, password);
            var resultUser2 = userRepository.Create(user, login + "1", password);
            var resultUser3 = userRepository.Create(user, login + "2", password);
            var userIds = new List<Guid> { resultUser1.Id };
            var newUserIds = new List<Guid> { resultUser2.Id, resultUser3.Id };
            _tempUsers.AddRange(userIds);
            _tempUsers.AddRange(newUserIds);
            var chatRepository = new ChatsRepository(ConnectionString);
            var resultChat = chatRepository.Create(title, userIds);
            _tempChats.Add(resultChat.Id);
            chatRepository.AddMembers(resultChat.Id, newUserIds);
            var chatMembers = chatRepository.GetChatUsers(resultChat.Id);

            //asserts
            Assert.AreEqual(true, chatMembers.Any(m => m.Id == resultUser2.Id));
            Assert.AreEqual(true, chatMembers.Any(m => m.Id == resultUser3.Id));
        }

        [TestMethod]
        public void ShouldDeleteMembersFromChat()
        {
            //arrange
            var user = new User
            {
                Name = "testCharUser",
                Picture = new byte[] {}
            };
            var login = "testCharUser";
            var password = "qwerty123";
            var title = "chatTitle";

            //act
            var userRepository = new UsersRepository(ConnectionString);
            var resultUser1 = userRepository.Create(user, login, password);
            var resultUser2 = userRepository.Create(user, login + "1", password);
            var resultUser3 = userRepository.Create(user, login + "2", password);
            var userIds = new List<Guid> { resultUser1.Id, resultUser2.Id, resultUser3.Id };
            var newUserIds = new List<Guid> { resultUser2.Id, resultUser3.Id };
            _tempUsers.AddRange(userIds);
            var chatRepository = new ChatsRepository(ConnectionString);
            var resultChat = chatRepository.Create(title, userIds);
            _tempChats.Add(resultChat.Id);
            chatRepository.DeleteMembers(resultChat.Id, newUserIds);
            var chatMembers = chatRepository.GetChatUsers(resultChat.Id);

            //asserts
            Assert.AreEqual(false, chatMembers.Any(m => m.Id == resultUser2.Id));
            Assert.AreEqual(false, chatMembers.Any(m => m.Id == resultUser3.Id));
        }

        [TestCleanup]
        public void Clean()
        {
            foreach (var id in _tempMessages)
                new MessagesRepository(ConnectionString).Delete(id);
            foreach (var id in _tempChats)
                new ChatsRepository(ConnectionString).Delete(id);
            foreach (var id in _tempUsers)
                new UsersRepository(ConnectionString).Delete(id);
        }
    }
}
