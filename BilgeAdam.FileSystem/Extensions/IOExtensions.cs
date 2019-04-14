using System.IO;

namespace BilgeAdam.FileSystem.Extensions
{
    public static class IOHelper
    {
        public static bool HasChildren(string path)
        {
            return Directory.GetDirectories(path).Length > 0 ||
                   Directory.GetFiles(path).Length > 0;
        }
    }
}
