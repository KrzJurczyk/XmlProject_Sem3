using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using XML_Project_Sem3.Interfaces;

namespace XML_Project_Sem3.Model.DataContainers
{
    [Serializable]
    public class CountryDivisionData : IDataProvider
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
