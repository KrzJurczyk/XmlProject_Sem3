using System;
using System.Xml.Serialization;

namespace XML_Project_Sem3.DataContainers
{
    [Serializable]
    public class DefaultPathData
    {
        [XmlAttribute("Path")]
        public string Path { get; set; }

        [XmlAttribute("FileName")]
        public string FileName { get; set; }
    }
}
