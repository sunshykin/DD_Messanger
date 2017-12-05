using System;
using System.Collections.Generic;
using ChatterBox.Model;

namespace ChatterBox.DataLayer
{
    public interface IChatsRepository
    {
        Chat Create(string title, IEnumerable<Guid> members, byte[] picture = null);
        void Delete(Guid id);
        Chat Get(Guid id);
        bool ChatExists(Guid id);

        IEnumerable<User> GetChatUsers(Guid id);
        IEnumerable<Attach> GetChatAttachs(Guid id);
        IEnumerable<Message> GetChatMessages(Guid id);

        void ChangeTitle(Guid id, string newTitle);
        void ChangePicture(Guid id, byte[] newPicture);
        void AddMembers(Guid id, IEnumerable<Guid> members);
        void DeleteMembers(Guid id, IEnumerable<Guid> members);
    }
}
