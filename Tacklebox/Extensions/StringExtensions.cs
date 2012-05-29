using System;

namespace Tacklebox.Extensions
{
    public static class StringExtensions
    {
        public static int ToInt32(this string self)
        {
            return Int32.Parse(self);
        }

        public static DateTime ToDateTime(this string self)
        {
            return DateTime.Parse(self);
        }
    }
}
