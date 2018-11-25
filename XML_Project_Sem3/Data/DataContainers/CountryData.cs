using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using XML_Project_Sem3.Interfaces;

namespace XML_Project_Sem3.Data.DataContainers
{
    [Serializable]
    public class CountryData : IDataProvider
    {
        #region Public Properties

        [XmlAttribute]
        public string Capital { get; set; }

        [XmlArray("Divisions")]
        [XmlArrayItem("Division")]
        public List<CountryDivisionData> CountryDivision { get; set; }

        [XmlAttribute]
        public string OfficialLanguages { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        #endregion
    }
}
