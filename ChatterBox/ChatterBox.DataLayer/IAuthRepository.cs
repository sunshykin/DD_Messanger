using System;
using ChatterBox.Model;

namespace ChatterBox.DataLayer
{
    public interface IAuthRepository
    {
        Auth Get(Guid userid);
        bool LoginExists(string login);
        bool CanSignIn(string login, string pass);
        User SignIn(string login, string pass);
    }
}
