namespace Tacklebox.Helper
{
    public class NullHelper
    {
        public string ToEmpty(string value)
        {
            return value ?? "";
        }
    }
}
