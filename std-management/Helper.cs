using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace std_management
{
    internal class Helper
    {
        public static string ConvertImageToBase64(Image file)
        {
            if (file == null) return "";
            using (MemoryStream memoryStream = new MemoryStream())
            {
                try
                {
                    file.Save(memoryStream, file.RawFormat);
                    byte[] imageBytes = memoryStream.ToArray();
                    return Convert.ToBase64String(imageBytes);
                }
                catch
                {

                }
            }
            return "";
        }
        public static Image ConvertBase64ToImage(string base64String)
        {
            try
            {

                byte[] imageBytes = Convert.FromBase64String(base64String);
                using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                {
                    ms.Write(imageBytes, 0, imageBytes.Length);
                    return Image.FromStream(ms, true);
                }
            }
            catch
            {

            }
            return null;
        }
    }
}
