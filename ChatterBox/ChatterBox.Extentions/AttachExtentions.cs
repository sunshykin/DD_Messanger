using ChatterBox.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatterBox.Model.Additional;

namespace ChatterBox.Extentions
{
    public static class AttachExtentions
    {
        public static File ToFile(this Attach attach)
        {
            return new File(attach.FileName, attach.FileData);
        }

        public static IEnumerable<File> ToFileList(this IEnumerable<Attach> attachs)
        {
            return attachs.Select(a => a.ToFile());
        }
    }
}
