using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
namespace DiffbotApi
{
    public class FrontpageItem
    {
        [XmlAttribute(AttributeName="cluster")]
        public string Cluster { get; set; }

        [XmlAttribute(AttributeName = "fresh")]
        public double Freshness { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "sp")]
        public double SpamScore { get; set; }

        [XmlAttribute(AttributeName = "sr")]
        public double StaticRank { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "xroot")]
        public string XRoot { get; set; }

        [XmlAttribute(AttributeName = "img")]
        public string Image { get; set; }

        [XmlElement(ElementName="title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "link")]
        public string Link { get; set; }

        [XmlElement(ElementName = "pubDate")]
        public string PublicationDate { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

    }
}
