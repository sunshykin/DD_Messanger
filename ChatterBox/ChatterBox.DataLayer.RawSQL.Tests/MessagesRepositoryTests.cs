using System;
using System.Collections.Generic;
using System.Linq;
using ChatterBox.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChatterBox.DataLayer.RawSQL.Tests
{
    [TestClass]
    public class MessagesRepositoryTests
    {
        private const string ConnectionString = @"Data Source=DESKTOP-C09EP1V\SQLEXPRESS;Initial Catalog=MessengerBase;Integrated Security=True;";

        private readonly List<Guid> _tempUsers = new List<Guid>();
        private readonly List<Guid> _tempChats = new List<Guid>();
        private readonly List<Guid> _tempMessages = new List<Guid>();

        [TestMethod]
        public void ShouldSendMessage()
        {
            //arrange
            var user = new User
            {
                Name = "testCharUser",
                Picture = "\\pic\\temp.jpg"
            };
            var login = "testCharUser";
            var password = "qwerty123";
            var title = "chatTitle";
            var pic = "";
            string msg = "TestText of msg";

            //act
            var userRepository = new UsersRepository(ConnectionString);
            var resultUser = userRepository.Create(user, login, password);
            var userIds = new List<Guid> { resultUser.Id};
            _tempUsers.AddRange(userIds);
            var chatRepository = new ChatsRepository(ConnectionString);
            var resultChat = chatRepository.Create(title, userIds, pic);
            _tempChats.Add(resultChat.Id);
            var messageRepository = new MessagesRepository(ConnectionString);
            var resultMsg = messageRepository.Send(msg, resultUser.Id, resultChat.Id);
            _tempMessages.Add(resultMsg.Id);

            //asserts
            Assert.AreEqual(msg, resultMsg.Text);
            Assert.AreEqual(resultUser.Id, resultMsg.Sender.Id);
            Assert.AreEqual(resultChat.Id, resultMsg.Chat.Id);
        }

        [TestMethod]
        public void ShouldSendAndDeleteMessage()
        {
            //arrange
            var user = new User
            {
                Name = "testCharUser",
                Picture = "\\pic\\temp.jpg"
            };
            var login = "testCharUser";
            var password = "qwerty123";
            var title = "chatTitle";
            var pic = "";
            string msg = "TestText of msg";

            //act
            var userRepository = new UsersRepository(ConnectionString);
            var resultUser = userRepository.Create(user, login, password);
            var userIds = new List<Guid> { resultUser.Id };
            _tempUsers.AddRange(userIds);
            var chatRepository = new ChatsRepository(ConnectionString);
            var resultChat = chatRepository.Create(title, userIds, pic);
            _tempChats.Add(resultChat.Id);
            var messageRepository = new MessagesRepository(ConnectionString);
            var resultMsg = messageRepository.Send(msg, resultUser.Id, resultChat.Id);
            messageRepository.Delete(resultMsg.Id);

            //asserts
            Assert.AreEqual(false, messageRepository.MessageExists(resultMsg.Id));
            Assert.AreEqual(false, chatRepository.GetChatMessages(resultChat.Id).Any(m => m.Id == resultMsg.Id));
        }

        [TestMethod]
        public void ShouldGetMessage()
        {
            //arrange
            var user = new User
            {
                Name = "testCharUser",
                Picture = "\\pic\\temp.jpg"
            };
            var login = "testCharUser";
            var password = "qwerty123";
            var title = "chatTitle";
            var pic = "";
            string msg = "TestText of msg";

            //act
            var userRepository = new UsersRepository(ConnectionString);
            var resultUser = userRepository.Create(user, login, password);
            var userIds = new List<Guid> { resultUser.Id };
            _tempUsers.AddRange(userIds);
            var chatRepository = new ChatsRepository(ConnectionString);
            var resultChat = chatRepository.Create(title, userIds, pic);
            _tempChats.Add(resultChat.Id);
            var messageRepository = new MessagesRepository(ConnectionString);
            var resultMsg = messageRepository.Send(msg, resultUser.Id, resultChat.Id);
            var getMsg = messageRepository.Get(resultMsg.Id);
            _tempMessages.Add(getMsg.Id);

            //asserts
            Assert.AreEqual(msg, getMsg.Text);
            Assert.AreEqual(resultUser.Id, getMsg.Sender.Id);
            Assert.AreEqual(resultChat.Id, getMsg.Chat.Id);

        }

        [TestMethod]
        public void ShouldCheckExistanceOfMessage()
        {
            //arrange
            var user = new User
            {
                Name = "testCharUser",
                Picture = "\\pic\\temp.jpg"
            };
            var login = "testCharUser";
            var password = "qwerty123";
            var title = "chatTitle";
            var pic = "";
            string msg = "TestText of msg";

            //act
            var userRepository = new UsersRepository(ConnectionString);
            var resultUser = userRepository.Create(user, login, password);
            var userIds = new List<Guid> { resultUser.Id };
            _tempUsers.AddRange(userIds);
            var chatRepository = new ChatsRepository(ConnectionString);
            var resultChat = chatRepository.Create(title, userIds, pic);
            _tempChats.Add(resultChat.Id);
            var messageRepository = new MessagesRepository(ConnectionString);
            var resultMsg = messageRepository.Send(msg, resultUser.Id, resultChat.Id);
            _tempMessages.Add(resultMsg.Id);

            //asserts
            Assert.AreEqual(true, messageRepository.MessageExists(resultMsg.Id));
            Assert.AreEqual(false, messageRepository.MessageExists(Guid.Empty));
        }

        [TestMethod]
        public void ShouldGetMessageAttachs()
        {
            //arrange
            var user = new User
            {
                Name = "testCharUser",
                Picture = "\\pic\\temp.jpg"
            };
            var login = "testCharUser";
            var password = "qwerty123";
            var title = "chatTitle";
            var pic = "";
            var atch = new List<string>() { "pic.jpg", "text.txt" };
            string msg = "TestText of msg";

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
            var resultMsg = messageRepository.Send(msg, resultUser1.Id, resultChat.Id, atch);
            var resultAttachs = messageRepository.GetMessageAttachs(resultMsg.Id);
            _tempMessages.Add(resultMsg.Id);

            //asserts
            Assert.AreEqual(2, resultAttachs.Count());
            Assert.AreEqual(true, resultAttachs.Any(a => a.Path == atch[0] && a.Sender.Id == resultUser1.Id));
            Assert.AreEqual(true, resultAttachs.Any(a => a.Path == atch[1] && a.Sender.Id == resultUser1.Id));
        }
        
        [TestMethod]
        public void ShouldGetMessagesFromUser()
        {
            //arrange
            var user = new User
            {
                Name = "testCharUser",
                Picture = "\\pic\\temp.jpg"
            };
            var login = "testCharUser";
            var password = "qwerty123";
            var title = "chatTitle";
            var pic = "";
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
            _tempMessages.Add(resultMsg1.Id);
            var resultMsg2 = messageRepository.Send(msg2, resultUser1.Id, resultChat.Id);
            _tempMessages.Add(resultMsg2.Id);
            var resultMsgs = messageRepository.GetMessagesFromUser(resultUser1.Id);

            //asserts
            Assert.AreEqual(true, resultMsgs.Any(m => m.Id == resultMsg1.Id));
            Assert.AreEqual(true, resultMsgs.Any(m => m.Id == resultMsg2.Id));
        }

        [TestMethod]
        public void ShouldGetMessagesToUser()
        {
            //arrange
            var user = new User
            {
                Name = "testCharUser",
                Picture = "\\pic\\temp.jpg"
            };
            var login = "testCharUser";
            var password = "qwerty123";
            var title = "chatTitle";
            var pic = "";
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
            _tempMessages.Add(resultMsg1.Id);
            var resultMsg2 = messageRepository.Send(msg2, resultUser1.Id, resultChat.Id);
            _tempMessages.Add(resultMsg2.Id);
            var resultMsgs = messageRepository.GetMessagesToUser(resultUser2.Id);

            //asserts
            Assert.AreEqual(2, resultMsgs.Count());
            Assert.AreEqual(true, resultMsgs.Any(m => m.Id == resultMsg1.Id));
            Assert.AreEqual(true, resultMsgs.Any(m => m.Id == resultMsg2.Id));
        }



        [TestMethod]
        public void ShouldSearchMessages()
        {
            //arrange
            var user = new User
            {
                Name = "testCharUser",
                Picture = "\\pic\\temp.jpg"
            };
            var login = "testCharUser";
            var password = "qwerty123";
            var title = "chatTitle";
            var pic = "";
            string msg1 = "TestText of msg";
            string msg2 = "TestText of nothing";
            string msg3 = "TestText of msg2";

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
            _tempMessages.Add(resultMsg1.Id);
            var resultMsg2 = messageRepository.Send(msg2, resultUser1.Id, resultChat.Id);
            _tempMessages.Add(resultMsg2.Id);
            var resultMsg3 = messageRepository.Send(msg3, resultUser2.Id, resultChat.Id);
            _tempMessages.Add(resultMsg3.Id);
            var resultMsgs = messageRepository.SearchMessages(resultUser2.Id, "msg");

            //asserts
            Assert.AreEqual(2, resultMsgs.Count());
            Assert.AreEqual(true, resultMsgs.Any(m => m.Id == resultMsg1.Id));
            Assert.AreEqual(false, resultMsgs.Any(m => m.Id == resultMsg2.Id));
            Assert.AreEqual(true, resultMsgs.Any(m => m.Id == resultMsg3.Id));
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
