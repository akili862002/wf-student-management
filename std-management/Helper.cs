using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace std_management
{
    internal class Helper
    {
        public static Image GetImageFromUrl(string url)
        {
            try
            {

                HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);

                using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    using (Stream stream = httpWebReponse.GetResponseStream())
                    {
                        Image img = Image.FromStream(stream);
                        return img;
                    }
                }
            }
            catch
            {

            }

            return null;
        }

    }
}
