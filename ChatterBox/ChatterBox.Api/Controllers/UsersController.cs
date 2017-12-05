using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;
using ChatterBox.Model.Additional;
using ChatterBox.DataLayer;
using ChatterBox.DataLayer.RawSQL;
using ChatterBox.Model;
using Microsoft.Web.Http;
using Microsoft.Web.Http.Routing;
using NLog;

namespace ChatterBox.Api.Controllers
{   
    [ApiVersion("0.1")]
    [RoutePrefix("api/v{version:apiVersion}/users")]
    public class UsersController : ApiController
    {
        private readonly IUsersRepository _usersRepository;
        private readonly string ConnectionString;
        private readonly Logger Log;

        public UsersController()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["ChatterBase"].ConnectionString;
            _usersRepository = new UsersRepository(ConnectionString);
            Log = LogManager.GetCurrentClassLogger();
        }
        
        [HttpPost]
        [Route("")]
        public User Create([FromBody] UserOnCreate user)
        {
            Log.Debug("Создание пользователя.");
            var result = _usersRepository.Create(new User() { Name = user.Name, Picture = user.Picture },
                user.Login, user.Password);
            Log.Debug($"Создание пользователя завершено, Id = {result.Id}.");
            return result;
        }

        [HttpGet]
        [Route("{id}")]
        public User Get([FromUri] Guid id)
        {
            Log.Debug($"Получение пользователя с Id = {id} из БД.");
            var result = _usersRepository.Get(id);
            Log.Debug("Получение пользователя из БД завершено.");
            return result;
        }

        [HttpGet]
        [Route("{id}/contacts")]
        public IEnumerable<User> GetContacts([FromUri] Guid id)
        {
            Log.Debug($"Получение контактов пользователя с Id = {id} из БД.");
            var result = _usersRepository.GetContacts(id);
            Log.Debug("Получение контактов пользователя из БД завершено.");
            return result;
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete([FromUri] Guid id)
        {
            Log.Debug($"Удаление пользователя с Id = {id} из БД.");
            _usersRepository.Delete(id);
            Log.Debug("Удаление пользователя из БД завершено.");
        }

        [HttpDelete]
        [Route("{userid}/delcontact/{contactid}")]
        public void DeleteContact([FromUri] Guid userid, [FromUri] Guid contactid)
        {
            Log.Debug($"Удаление контакта с Id = {userid} пользователя с Id = {userid} из БД.");
            _usersRepository.DeleteContact(userid, contactid);
            Log.Debug("Удаление контакта из БД завершено.");
        }

        [HttpGet]
        [Route("{id}/exists")]
        public bool Exists([FromUri] Guid id)
        {
            Log.Debug("Выполнение функции Exists.");
            var result = _usersRepository.UserExists(id);
            Log.Debug("Выполнение функции Exists завершено.");
            return result;
        }

        [HttpPost]
        [Route("{id}/changename")]
        public void ChangeName([FromUri] Guid id, [FromBody] string newName)
        {
            Log.Debug($"Смена имени пользователя с Id = {id}.");
            _usersRepository.ChangeName(id, newName);
            Log.Debug("Смена логина пользователя завершена.");
        }

        [HttpPost]
        [Route("{id}/changelogin")]
        public void ChangeLogin([FromUri] Guid id, [FromBody] string[] parametrs)
        {
            Log.Debug($"Смена логина пользователя с Id = {id}.");
            if (parametrs == null || parametrs.Length != 2)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Неверное количество введенных параметров"),
                    ReasonPhrase = "Wrong User Arguments"
                };
                throw new HttpResponseException(resp);
            }
            _usersRepository.ChangeLogin(id, parametrs[0], parametrs[1]);
            Log.Debug("Смена логина пользователя завершена.");
        }

        [HttpPost]
        [Route("{id}/changepass")]
        public void ChangePassword([FromUri] Guid id, [FromBody] string[] parametrs)
        {
            Log.Debug($"Смена пароля пользователя с ID = {id}.");
            if (parametrs == null || parametrs.Length != 2)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Неверное количество введенных параметров"),
                    ReasonPhrase = "Wrong User Arguments"
                };
                throw new HttpResponseException(resp);
            }
            _usersRepository.ChangePassword(id, parametrs[0], parametrs[1]);
            Log.Debug("Смена пароля пользователя завершена.");
        }

        [HttpPost]
        [Route("{id}/changepicture")]
        public void ChangePicture([FromUri] Guid id, [FromBody] byte[] picture)
        {
            Log.Debug($"Смена аватара пользователя с ID = {id}.");
            _usersRepository.ChangePicture(id, picture);
            Log.Debug("Смена аватара пользователя завершена.");
        }

        [HttpPost]
        [Route("signin")]
        public User SignIn([FromBody] string[] loginpass)
        {
            Log.Debug("Выполнение входа в систему.");
            if (loginpass == null || loginpass.Length != 2)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Неверное количество введенных параметров"),
                    ReasonPhrase = "Wrong User Arguments"
                };
                throw new HttpResponseException(resp);
            }
            var result = _usersRepository.SignIn(loginpass[0], loginpass[1]);
            Log.Debug("Выполнение входа в систему завершено.");
            return result;
        }

        [HttpGet]
        [Route("{id}/chats")]
        public IEnumerable<Chat> GetUserChats([FromUri] Guid id)
        {
            Log.Debug("Выполнение функции GetUserChats.");
            var result = _usersRepository.GetUserChats(id);
            Log.Debug("Выполнение функции GetUserChats завершено.");
            return result;
        }

    }
}
