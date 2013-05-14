using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tacklebox.Helper
{
    public class NumberHelper
    {
        public static int? Int32ParseWithNull(string number)
        {
            if (String.IsNullOrEmpty(number))
            {
                return null;
            }
            return Int32.Parse(number);
        }
    }
}
