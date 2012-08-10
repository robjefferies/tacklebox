using System;
using System.Collections.Generic;

namespace Tacklebox.Extensions
{
    public static class ExceptionExtensions
    {
        public static Exception Innermost(this Exception self)
        {
            var ex = self;
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }
            return ex;
        }

        public static List<String> MessageList(this Exception self)
        {
            var ex = self;
            var list = new List<string> {self.Message};

            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
                list.Add(ex.Message);
            }
            return list;
        } 
    }
}