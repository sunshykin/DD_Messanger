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
    [RoutePrefix("api/v{version:apiVersion}/chats")]
    public class ChatsController : ApiController
    {
        private readonly IChatsRepository _chatsRepository;
        private const string ConnectionString = @"Data Source=DESKTOP-C09EP1V\SQLEXPRESS;Initial Catalog=MessengerBase;Integrated Security=True;";

        public ChatsController()
        {
            _chatsRepository = new ChatsRepository(ConnectionString);
        }

        [HttpPost]
        [Route("")]
        public Chat Create([FromBody] ChatOnCreate chat)
        {
            try
            {
                return _chatsRepository.Create(chat.Title, chat.Members, chat.Picture);
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
                _chatsRepository.Delete(id);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, e.Message));
            }
        }

        [HttpGet]
        [Route("{id}")]
        public Chat Get([FromUri] Guid id)
        {
            try
            {
                return _chatsRepository.Get(id);
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
            return _chatsRepository.ChatExists(id);
        }

        [HttpPost]
        [Route("{id}/changetitle")]
        public void ChangeTitle([FromUri] Guid id, [FromBody] string newTitle)
        {
            try
            {
                _chatsRepository.ChangeTitle(id, newTitle);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, e.Message));
            }
        }

        [HttpPost]
        [Route("{id}/changepicture")]
        public void ChangePicture([FromUri] Guid id, [FromBody] string newPicture)
        {
            try
            {
                _chatsRepository.ChangePicture(id, newPicture);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, e.Message));
            }
        }

        [HttpPost]
        [Route("{id}/add")]
        public void AddMembers([FromUri] Guid id, [FromBody] IEnumerable<Guid> members)
        {
            try
            {
                _chatsRepository.AddMembers(id, members);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, e.Message));
            }
        }

        [HttpDelete]
        [Route("{id}/del")]
        public void DeleteMembers([FromUri] Guid id, [FromBody] IEnumerable<Guid> members)
        {
            try
            {
                _chatsRepository.DeleteMembers(id, members);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, e.Message));
            }
        }

        [HttpGet]
        [Route("{id}/users")]
        public IEnumerable<User> GetChatUsers([FromUri] Guid id)
        {
            try
            {
                return _chatsRepository.GetChatUsers(id);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, e.Message));
            }
        }

        [HttpGet]
        [Route("{id}/messages")]
        public IEnumerable<Message> GetChatMessages([FromUri] Guid id)
        {
            try
            {
                return _chatsRepository.GetChatMessages(id);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, e.Message));
            }
        }

        [HttpGet]
        [Route("{id}/attachs")]
        public IEnumerable<Attach> GetChatAttachs([FromUri] Guid id)
        {
            try
            {
                return _chatsRepository.GetChatAttachs(id);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, e.Message));
            }
        }

    }
}
