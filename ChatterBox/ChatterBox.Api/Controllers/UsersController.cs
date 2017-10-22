using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;
using ChatterBox.Api.Models;
using ChatterBox.DataLayer;
using ChatterBox.DataLayer.RawSQL;
using ChatterBox.Model;
using Microsoft.Web.Http;
using Microsoft.Web.Http.Routing;

namespace ChatterBox.Api.Controllers
{   
    [ApiVersion("0.1")]
    [RoutePrefix("api/v{version:apiVersion}/users")]
    public class UsersController : ApiController
    {
        private readonly IUsersRepository _usersRepository;
        private const string ConnectionString = @"Data Source=DESKTOP-C09EP1V\SQLEXPRESS;Initial Catalog=MessengerBase;Integrated Security=True;";
        
        public UsersController()
        {
            _usersRepository = new UsersRepository(ConnectionString);
        }
        
        [HttpPost]
        [Route("")]
        public User Create([FromBody] UserOnCreate user)
        {
            try
            {
                return _usersRepository.Create(new User() {Name = user.Name, Picture = user.Picture},
                    user.Login, user.Password);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, e.Message));
            }
        }

        [HttpGet]
        [Route("{id}")]
        public User Get([FromUri] Guid id)
        {
            try
            {
                return _usersRepository.Get(id);
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
                _usersRepository.Delete(id);
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
            return _usersRepository.UserExists(id);
        }

        [HttpPost]
        [Route("{id}/changelogin")]
        public void ChangeLogin([FromUri] Guid id, [FromBody] string[] parametrs)
        {
            try
            {
                if (parametrs == null || parametrs.Length != 2)
                    throw new ArgumentException("Неверное количество введенных параметров");
                _usersRepository.ChangeLogin(id, parametrs[0], parametrs[1]);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, e.Message));
            }
        }

        [HttpPost]
        [Route("{id}/changepass")]
        public void ChangePassword([FromUri] Guid id, [FromBody] string[] parametrs)
        {
            try
            {
                if (parametrs == null || parametrs.Length != 2)
                    throw new ArgumentException("Неверное количество введенных параметров");
                _usersRepository.ChangePassword(id, parametrs[0], parametrs[1]);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, e.Message));
            }
        }

        [HttpPost]
        [Route("signin")]
        public User SignIn([FromBody] string[] loginpass)
        {
            try
            {
                if (loginpass == null || loginpass.Length != 2)
                    throw new ArgumentException("Неверное количество введенных параметров");
                return _usersRepository.SignIn(loginpass[0], loginpass[1]);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, e.Message));
            }
        }

        [HttpGet]
        [Route("{id}/chats")]
        public IEnumerable<Chat> GetUserChats([FromUri] Guid id)
        {
            try
            {
                return _usersRepository.GetUserChats(id);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, e.Message));
            }
        }

    }
}
