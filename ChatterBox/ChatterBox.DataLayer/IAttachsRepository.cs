using System;
using System.Collections.Generic;
using ChatterBox.Model;

namespace ChatterBox.DataLayer
{
    public interface IAttachsRepository
    {
        void Delete(Guid id);
        Attach Get(Guid id);
        bool AttachExists(Guid id);
    }
}
