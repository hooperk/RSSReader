using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml;
using System.IO;

namespace RSSReader
{
    public static class RssManager
    {
        public static void RefreshRSS(string rssURL)
        {
            WebRequest myRequest = WebRequest.Create(rssURL);
            WebResponse myResponse = myRequest.GetResponse();

            Stream rssStream = myResponse.GetResponseStream();

            XmlDocument rssDoc = new XmlDocument();

            rssDoc.Load(rssStream);

            XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");

            string title = "";
            string link = "";
            string description = "";

            for (int i = 0; i < rssItems.Count; i++)
            {
                XmlNode rssDetail = rssItems[i].SelectSingleNode("title");
                if (rssDetail != null)
                    title = rssDetail.InnerText;
                else
                    title = "";

                rssDetail = rssItems[i].SelectSingleNode("link");
                if (rssDetail != null)
                    link = rssDetail.InnerText;
                else
                    link = "";

                rssDetail = rssItems[i].SelectSingleNode("description");
                if (rssDetail != null)
                    description = rssDetail.InnerText;
                else
                    link = "";

                MessageBox.Show(title + link + description);
            }
        }
    }
}
