using System;
using System.Xml.Serialization;

namespace XML_Project_Sem3.DataContainers
{
    [Serializable]
    [XmlRoot(ElementName = "Config")]
    public class ConfigData
    {
        [XmlElement("DefaultPath")]
        public DefaultPathData DefaultPath = new DefaultPathData();
    }
}
