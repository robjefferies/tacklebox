using System;

namespace Tacklebox.Extensions
{
    public static class StringExtensions
    {
        public static int ToInt32(this string self)
        {
            return Int32.Parse(self);
        }

        public static double ToDouble(this string self)
        {
            return Double.Parse(self);
        }

        public static DateTime ToDateTime(this string self)
        {
            return DateTime.Parse(self);
        }

        public static bool ToBool(this string self)
        {
            self = self.Trim().ToUpper();

            if (self.Equals("Y")) { return true; }
            if (self.Equals("N")) { return false; }
            if (self.Equals("YES")) { return true; }
            if (self.Equals("NO")) { return false; }
            if (self.Equals("T")) { return true; }
            if (self.Equals("F")) { return false; }
            if (self.Equals("TRUE")) { return true; }
            if (self.Equals("FALSE")) { return false; }
            if (self.Equals("0")) { return false; }
            if (self.Equals("1")) { return true; }
            else
            {
                return bool.Parse(self);
            }
        }

        public static string Right(this string self, int size)
        {
            return self.Substring(self.Length - size, size);
        }

        public static bool IsNumeric(this string self)
        {
            decimal parseResult = 0;
            return Decimal.TryParse(self, out parseResult);
        }
    }
}
