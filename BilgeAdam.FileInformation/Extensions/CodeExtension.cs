using BilgeAdam.FileInformation.Enums;
using System.IO;

namespace BilgeAdam.FileInformation.Extensions
{
    public static class CodeExtension
    {
        public static string GetSize(this long size)
        {
            return size / (1024 * 1024 * 1024) > 0 ?
                    (size / (1024 * 1024 * 1024) + " GB") :
                        size / (1024 * 1024) > 0 ?
                        (size / (1024 * 1024) + " MB") :
                            size / 1024 > 0 ?
                            (size / 1024) + " KB" : 
                                size + " B";
        }

        public static int GetImageKey(this string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                return (int)ImageCode.Other;
            }
            var info = new FileInfo(fileName);
            switch (info.Extension)
            {
                case ".json":
                case ".xml":
                    return (int)ImageCode.Json;
                case ".jpg":
                case ".jpeg":
                case ".png":
                case ".gif":
                case ".tif":
                    return (int)ImageCode.Image;
                case ".txt":
                case ".log":
                case ".sys":
                case ".inf":
                    return (int)ImageCode.Text;
                default:
                    return (int)ImageCode.Other;
            }
        }
    }
}
