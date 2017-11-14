using System;
using System.Collections.Generic;
using System.Web.Http;
using ChatterBox.Model.Additional;
using ChatterBox.DataLayer;
using ChatterBox.DataLayer.RawSQL;
using ChatterBox.Model;
using Microsoft.Web.Http;
using NLog;

namespace ChatterBox.Api.Controllers
{
    [ApiVersion("0.1")]
    [RoutePrefix("api/v{version:apiVersion}/chats")]
    public class ChatsController : ApiController
    {
        private readonly IChatsRepository _chatsRepository;
        private const string ConnectionString = @"Data Source=DESKTOP-C09EP1V\SQLEXPRESS;Initial Catalog=MessengerBase;Integrated Security=True;";
        private readonly Logger Log;

        public ChatsController()
        {
            _chatsRepository = new ChatsRepository(ConnectionString);
            Log = LogManager.GetCurrentClassLogger();
        }

        [HttpPost]
        [Route("")]
        public Chat Create([FromBody] ChatOnCreate chat)
        {
            Log.Debug("Создание чата.");
            var result = _chatsRepository.Create(chat.Title, chat.Members, chat.Picture);
            Log.Debug($"Создание чата завершено, Id = {result.Id}.");
            return result;
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete([FromUri] Guid id)
        {
            Log.Debug($"Удаление чата с Id = {id} из БД.");
            _chatsRepository.Delete(id);
            Log.Debug("Удаление чата завершено.");
        }

        [HttpGet]
        [Route("{id}")]
        public Chat Get([FromUri] Guid id)
        {
            Log.Debug($"Получение чата с Id = {id} из БД.");
            var result = _chatsRepository.Get(id);
            Log.Debug($"Получение чата из БД завершено.");
            return result;
        }

        [HttpGet]
        [Route("{id}/exists")]
        public bool Exists([FromUri] Guid id)
        {
            Log.Debug("Выполнение функции Exists.");
            var result = _chatsRepository.ChatExists(id);
            Log.Debug("Выполнение функции Exists завершено.");
            return result;
        }

        [HttpPost]
        [Route("{id}/changetitle")]
        public void ChangeTitle([FromUri] Guid id, [FromBody] string newTitle)
        {
            Log.Debug($"Смена названия чата с Id = {id}.");
            _chatsRepository.ChangeTitle(id, newTitle);
            Log.Debug("Смена названия чата завершена.");
        }

        [HttpPost]
        [Route("{id}/changepicture")]
        public void ChangePicture([FromUri] Guid id, [FromBody] string newPicture)
        {
            Log.Debug($"Смена аватара чата с Id = {id}.");
            _chatsRepository.ChangePicture(id, newPicture);
            Log.Debug("Смена аватара чата завершена.");
        }

        [HttpPost]
        [Route("{id}/add")]
        public void AddMembers([FromUri] Guid id, [FromBody] IEnumerable<Guid> members)
        {
            Log.Debug($"Добавление новых пользователей в чат с Id = {id}.");
            _chatsRepository.AddMembers(id, members);
            Log.Debug("Добавление новых пользователей в чат завершено.");
        }

        [HttpDelete]
        [Route("{id}/del")]
        public void DeleteMembers([FromUri] Guid id, [FromBody] IEnumerable<Guid> members)
        {
            Log.Debug($"Добавление новых пользователей в чат с Id = {id}.");
            _chatsRepository.DeleteMembers(id, members);
            Log.Debug("Добавление новых пользователей в чат завершено.");
        }

        [HttpGet]
        [Route("{id}/users")]
        public IEnumerable<User> GetChatUsers([FromUri] Guid id)
        {
            Log.Debug("Выполнение функции GetChatUsers.");
            var result = _chatsRepository.GetChatUsers(id);
            Log.Debug("Выполнение функции GetChatUsers завершено.");
            return result;
        }

        [HttpGet]
        [Route("{id}/messages")]
        public IEnumerable<Message> GetChatMessages([FromUri] Guid id)
        {
            Log.Debug("Выполнение функции GetChatMessages.");
            var result = _chatsRepository.GetChatMessages(id);
            Log.Debug("Выполнение функции GetChatMessages завершено.");
            return result;
        }

        [HttpGet]
        [Route("{id}/attachs")]
        public IEnumerable<Attach> GetChatAttachs([FromUri] Guid id)
        {
            Log.Debug("Выполнение функции GetChatAttachs.");
            var result = _chatsRepository.GetChatAttachs(id);
            Log.Debug("Выполнение функции GetChatAttachs завершено.");
            return result;
        }

    }
}
