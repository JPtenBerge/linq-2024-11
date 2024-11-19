using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Utils
{
    public static class DateTimeExtensions
    {
        public static string ToPrettyString(this DateTime dateTime)
        {
            return dateTime.ToString("d MMMM yyyy HH:mm");
        }
    }
}
