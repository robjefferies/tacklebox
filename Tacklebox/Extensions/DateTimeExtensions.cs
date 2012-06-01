using System;

namespace Tacklebox.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime Min(this DateTime t1, DateTime t2)
        {
            if (DateTime.Compare(t1, t2) > 0)
            {
                return t2;
            }
            return t1;
        }
        public static DateTime Max(this DateTime t1, DateTime t2)
        {
            if (DateTime.Compare(t1, t2) < 0)
            {
                return t2;
            }
            return t1;
        } 
    }
}