using System;
using System.Collections.Generic;
using ChatterBox.Model;

namespace ChatterBox.DataLayer
{
    public interface IMessagesRepository
    {
        Message Send(string text, Guid userid, Guid chatid, IEnumerable<string> files,
            bool selfDestruction, string destructionTime);
        void Delete(Guid id);
        Message Get(Guid id);
        bool MessageExists(Guid id);
        
        IEnumerable<Attach> GetMessageAttachs(Guid messageid);
        IEnumerable<Message> GetMessagesFromUser(Guid userid);
        IEnumerable<Message> GetMessagesToUser(Guid userid);
        IEnumerable<Message> SearchMessages(Guid userid, string keyword);
    }
}
