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
        private WebProxy _proxy;

        public Diffbot(string token)
        {
            DeveloperToken = token;
        }

        public Diffbot(string token, WebProxy proxy) : this(token)
        {
            _proxy = proxy;
        }

        public Frontpage Frontpage(string url)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Proxy = _proxy;
				wc.Encoding = Encoding.UTF8;
                string xmlString = wc.DownloadString(getQueryUrl(FRONTPAGE_API_SUFFIX, url));
                XmlSerializer ser = new XmlSerializer(typeof(Frontpage));
                return (Frontpage)ser.Deserialize(new StringReader(xmlString));
            }
        }

        public Article Article(string url, bool comments = false, bool keepAds = false, bool stats = false, bool summary = false, bool tags = false)
        {
            using (WebClient wc = new WebClient())
            {
                List<OptionalParameter> args = new List<OptionalParameter>();
                if(comments)
                    args.Add(new OptionalParameter() { Name = "comments", Value = "true" });
                if (keepAds)
                    args.Add(new OptionalParameter() { Name = "dontStripAds", Value = "true" });
                if (stats)
                    args.Add(new OptionalParameter() { Name = "stats", Value = "true" });
                if (summary)
                    args.Add(new OptionalParameter() { Name = "summary", Value = "true" });
                if (tags)
                    args.Add(new OptionalParameter() { Name = "tags", Value = "true" });
                
                wc.Proxy = null;
				wc.Encoding = Encoding.UTF8;
                string jsonString = wc.DownloadString(getQueryUrl(ARTICLE_API_SUFFIX, url, args.ToArray()));
                return new Article(jsonString);
            }
        }

        private string getQueryUrl(string queryType, string url, params OptionalParameter[] args)
        {
            string result = DIFFBOT_API_URL + queryType + "?token=" + DeveloperToken + "&url=" + HttpUtility.UrlEncode(url);
            foreach (var arg in args)
                result += "&" + arg.Name + "=" + HttpUtility.UrlEncode(arg.Value);
            return result;
        }

        private class OptionalParameter
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }
    }
}
