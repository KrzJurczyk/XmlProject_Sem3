using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XML_Project_Sem3.DataContainers
{
    [Serializable]
    public class CountryDivisionData
    {
        #region Public Properties

        [XmlAttribute]
        public string Capital { get; set; }

        [XmlArray("Cities")]
        [XmlArrayItem("City")]
        public List<CityData> Cities { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        #endregion
    }
}
