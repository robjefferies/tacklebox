using System;
using Tacklebox.Extensions;

namespace Tacklebox.Helper
{
    public class DateHelper
    {
        /* Determines the number of years between two dates.  What's needed for Age or Years of Safety etc. */
        public static int Age(DateTime date1, DateTime date2)
        {
            DateTime startDate = date1.Min(date2);
            DateTime endDate = date1.Max(date2);

            int age = endDate.Year - startDate.Year;
            if (startDate > endDate.AddYears(-age)) age--;
            return age;
        } 
    }
}