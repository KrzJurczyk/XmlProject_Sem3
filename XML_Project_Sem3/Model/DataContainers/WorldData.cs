using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using XML_Project_Sem3.Interfaces;

namespace XML_Project_Sem3.Model.DataContainers
{
    [Serializable]
    [XmlRoot(ElementName = "World")]
    public class WorldData : IDataProvider
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
