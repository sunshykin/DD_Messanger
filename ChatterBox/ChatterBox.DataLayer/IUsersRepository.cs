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
        bool UserExists(Guid id);
        void ChangeLogin(Guid userid, string newLogin, string pass);
        void ChangePassword(Guid userid, string oldPassword, string newPassword);

        IEnumerable<Chat> GetUserChats(Guid userid);
    }
}
