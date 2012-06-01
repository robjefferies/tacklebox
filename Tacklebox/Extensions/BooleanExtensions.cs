namespace Tacklebox.Extensions
{
    public static class BooleanExtensions
    {
        public static int ToInt32(this bool self)
        {
            return (self) ? 1 : 0;
        }
    }
}