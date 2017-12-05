using System;
using System.Collections.Generic;
using ChatterBox.Model;

namespace ChatterBox.DataLayer
{
    public interface IUsersRepository
    {
        User Create(User user, string login, string pass);
        void Delete(Guid id);
        User Get(Guid id);
        IEnumerable<User> GetContacts(Guid id);
        bool UserExists(Guid id);
        void ChangeName(Guid userid, string newName);
        void ChangeLogin(Guid userid, string newLogin, string pass);
        void ChangePassword(Guid userid, string oldPassword, string newPassword);
        void ChangePicture(Guid userid, byte[] picture);
        void DeleteContact(Guid userid, Guid contactid);

        User SignIn(string login, string pass);

        IEnumerable<Chat> GetUserChats(Guid userid);
    }
}
