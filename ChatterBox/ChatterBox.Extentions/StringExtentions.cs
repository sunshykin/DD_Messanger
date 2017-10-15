using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatterBox.Extentions
{
    public static class StringExtentions
    {
        public static bool IsEmpty(this string str)
        {
            if (str == null || str.Trim(' ') == String.Empty)
                return true;
            return false;
        }
    }
}
