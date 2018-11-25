using System;
using System.Xml.Serialization;
using XML_Project_Sem3.Interfaces;

namespace XML_Project_Sem3.Data.DataContainers
{
    [Serializable]
    [XmlRoot(ElementName = "Config")]
    public class ConfigData : IDataProvider
    {
        [XmlElement("DefaultPath")]
        public DefaultPathData DefaultPath = new DefaultPathData();
    }
}
