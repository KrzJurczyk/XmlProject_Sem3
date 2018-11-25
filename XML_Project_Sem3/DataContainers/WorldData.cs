using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XML_Project_Sem3.DataContainers
{
    [Serializable]
    [XmlRoot(ElementName = "World")]
    public class WorldData
    {
        #region Public Properties

        [XmlArray("Countries")]
        [XmlArrayItem("Country")]
        public List<CountryData> Countries { get; set; }

        [XmlAttribute]
        public int Age { get; set; }

        #endregion
    }
}
