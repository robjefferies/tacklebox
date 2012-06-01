using System;
using Tacklebox.Extensions;

namespace Tacklebox.Formatter
{
    public class StringFormat
    {
        public static string SSN(string ssn)
        {
            return SSN(ssn.ToInt32());
        } 

        public static string SSN(int ssn)
        {
            return String.Format("{0:000-00-0000}", ssn);
        }
    }
}