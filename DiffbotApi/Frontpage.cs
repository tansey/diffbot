using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DiffbotApi
{
    [XmlRoot(ElementName="dml")]
    public class Frontpage
    {
        [XmlElement(ElementName="info")]
        public FrontpageInfo Info { get; set; }

        [XmlElement("item", typeof(FrontpageItem))]
        public FrontpageItem[] Items { get; set; }
    }
}
