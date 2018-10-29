using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SoundManeger
{
    [XmlRoot("setting")]
    public class setting
    {
        [XmlElement("filters")]
        public Filters filters { get; set; }
    }

    public class Filters
    {
        [XmlElement("filter")]
        public List<Filter> fil { get; set; }
    }

    public class Filter
    {
        [XmlElement("filterName")]
        public string filterName { get; set; }
        [XmlArray("favorites")]
        [XmlArrayItem("favorite")]
        public List<string> fav { get; set; }
    }


}
