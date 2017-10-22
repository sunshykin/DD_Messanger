using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ChatterBox.Api.Models;
using ChatterBox.DataLayer;
using ChatterBox.DataLayer.RawSQL;
using ChatterBox.Model;
using Microsoft.Web.Http;

namespace ChatterBox.Api.Controllers
{
    [ApiVersion("0.1")]
    [RoutePrefix("api/v{version:apiVersion}/messages")]
    public class MessagesController : ApiController
    {
        private readonly IMessagesRepository _messagesRepository;
        private const string ConnectionString = @"Data Source=DESKTOP-C09EP1V\SQLEXPRESS;Initial Catalog=MessengerBase;Integrated Security=True;";

        public MessagesController()
        {
            _messagesRepository = new MessagesRepository(ConnectionString);
        }

        [HttpPost]
        [Route("")]
        public Message Create([FromBody] MessageOnCreate msg)
        {
            try
            {
                return _messagesRepository.Send(msg.Text, msg.UserId, msg.ChatId, msg.Files, 
                    msg.SelfDestruction, msg.DestructionTime);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, e.Message));
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete([FromUri] Guid id)
        {
            try
            {
                _messagesRepository.Delete(id);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, e.Message));
            }
        }

        [HttpGet]
        [Route("{id}")]
        public Message Get([FromUri] Guid id)
        {
            try
            {
                return _messagesRepository.Get(id);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, e.Message));
            }
        }

        [HttpGet]
        [Route("{id}/exists")]
        public bool Exists([FromUri] Guid id)
        {
            return _messagesRepository.MessageExists(id);
        }

        [HttpGet]
        [Route("{id}/attachs")]
        public IEnumerable<Attach> GetMessageAttachs([FromUri] Guid id)
        {
            try
            {
                return _messagesRepository.GetMessageAttachs(id);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, e.Message));
            }
        }

        [HttpGet]
        [Route("fromuser/{id}")]
        public IEnumerable<Message> GetMessageFromUser([FromUri] Guid id)
        {
            try
            {
                return _messagesRepository.GetMessagesFromUser(id);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, e.Message));
            }
        }

        [HttpGet]
        [Route("touser/{id}")]
        public IEnumerable<Message> GetMessageToUser([FromUri] Guid id)
        {
            try
            {
                return _messagesRepository.GetMessagesToUser(id);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, e.Message));
            }
        }

        [HttpPost]
        [Route("search")]
        public IEnumerable<Message> Search([FromBody] SearchInfo search)
        {
            try
            {
                return _messagesRepository.SearchMessages(search.UserId, search.KeyWord);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, e.Message));
            }
        }
    }
}
