using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tacklebox.IO
{
    public class File
    {
        public static void DeleteSilent(string filename)
        {
            try
            {
                System.IO.File.Delete(filename);
            }
            catch
            {
            }
        }
    }
}
