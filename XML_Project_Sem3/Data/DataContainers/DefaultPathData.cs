using System;
using System.Xml.Serialization;
using XML_Project_Sem3.Interfaces;

namespace XML_Project_Sem3.Data.DataContainers
{
    [Serializable]
    public class DefaultPathData : IDataProvider
    {
        [XmlAttribute("Path")]
        public string Path { get; set; }

        [XmlAttribute("FileName")]
        public string FileName { get; set; }
    }
}
