using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
    [RoutePrefix("api/v{version:apiVersion}/messages")]
    public class MessagesController : ApiController
    {
        private readonly IMessagesRepository _messagesRepository;
        private const string ConnectionString = @"Data Source=DESKTOP-C09EP1V\SQLEXPRESS;Initial Catalog=MessengerBase;Integrated Security=True;";
        private readonly Logger Log;

        public MessagesController()
        {
            _messagesRepository = new MessagesRepository(ConnectionString);
            Log = LogManager.GetCurrentClassLogger();
        }

        [HttpPost]
        [Route("")]
        public Message Create([FromBody] MessageOnCreate msg)
        {
            Log.Debug("Создание сообщения.");
            var result = _messagesRepository.Send(msg.Text, msg.UserId, msg.ChatId, msg.Files,
                msg.SelfDestruction, msg.DestructionTime);
            Log.Debug($"Создание сообщения завершено, Id = {result.Id}.");
            return result;
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete([FromUri] Guid id)
        {
            Log.Debug($"Удаление сообщения с Id = {id} из БД.");
            _messagesRepository.Delete(id);
            Log.Debug("Удаление сообщения завершено.");
        }

        [HttpGet]
        [Route("{id}")]
        public Message Get([FromUri] Guid id)
        {
            Log.Debug($"Получение сообщения с Id = {id} из БД.");
            var result = _messagesRepository.Get(id);
            Log.Debug($"Получение сообщения из БД завершено.");
            return result;
        }

        [HttpGet]
        [Route("{id}/exists")]
        public bool Exists([FromUri] Guid id)
        {
            Log.Debug("Выполнение функции Exists.");
            var result = _messagesRepository.MessageExists(id);
            Log.Debug("Выполнение функции Exists завершено.");
            return result;
        }

        [HttpGet]
        [Route("{id}/attachs")]
        public IEnumerable<Attach> GetMessageAttachs([FromUri] Guid id)
        {
            Log.Debug("Выполнение функции GetMessageAttachs.");
            var result = _messagesRepository.GetMessageAttachs(id);
            Log.Debug("Выполнение функции GetMessageAttachs завершено.");
            return result;
        }

        [HttpGet]
        [Route("fromuser/{id}")]
        public IEnumerable<Message> GetMessageFromUser([FromUri] Guid id)
        {
            Log.Debug("Выполнение функции GetMessageFromUser.");
            var result = _messagesRepository.GetMessagesFromUser(id);
            Log.Debug("Выполнение функции GetMessageFromUser завершено.");
            return result;
        }

        [HttpGet]
        [Route("touser/{id}")]
        public IEnumerable<Message> GetMessageToUser([FromUri] Guid id)
        {
            Log.Debug("Выполнение функции GetMessageToUser.");
            var result = _messagesRepository.GetMessagesToUser(id);
            Log.Debug("Выполнение функции GetMessageToUser завершено.");
            return result;
        }

        [HttpPost]
        [Route("search")]
        public IEnumerable<Message> Search([FromBody] SearchInfo search)
        {
            Log.Debug($"Поиск сообщений по фразе \"{search.KeyWord}\".");
            var result = _messagesRepository.SearchMessages(search.UserId, search.KeyWord);
            Log.Debug($"Поиск сообщений по фразе \"{search.KeyWord}\" завершен.");
            return result;
        }
    }
}
