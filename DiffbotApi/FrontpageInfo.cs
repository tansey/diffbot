using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DiffbotApi
{
    public class FrontpageInfo
    {
        [XmlElement(ElementName="title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "sourceType")]
        public string SourceType { get; set; }
        [XmlElement(ElementName = "icon")]
        public string Icon { get; set; }
        [XmlElement(ElementName = "numItems")]
        public int NumItems { get; set; }
        [XmlElement(ElementName = "numSpamItems")]
        public int NumSpamItems { get; set; }
    }
}
