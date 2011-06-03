using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml.Serialization;
using System.IO;
using System.Web;
namespace DiffbotApi
{
    public class Diffbot
    {
        private const string DIFFBOT_API_URL = "http://www.diffbot.com/api/";
        private const string ARTICLE_API_SUFFIX = "article";
        private const string FRONTPAGE_API_SUFFIX = "frontpage";
        public string DeveloperToken { get; set; }

        public Diffbot(string token)
        {
            DeveloperToken = token;
        }

        public Frontpage Frontpage(string url)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Proxy = null;
                string xmlString = wc.DownloadString(getQueryUrl(FRONTPAGE_API_SUFFIX, url));
                XmlSerializer ser = new XmlSerializer(typeof(Frontpage));
                return (Frontpage)ser.Deserialize(new StringReader(xmlString));
            }

        }

        public Article Article(string url)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Proxy = null;
                string jsonString = wc.DownloadString(getQueryUrl(ARTICLE_API_SUFFIX, url));
                return new Article(jsonString);
            }
        }

        private string getQueryUrl(string queryType, string url)
        {
            return DIFFBOT_API_URL + queryType + "?token=" + DeveloperToken + "&url=" + HttpUtility.UrlEncode(url);
        }
    }
}
