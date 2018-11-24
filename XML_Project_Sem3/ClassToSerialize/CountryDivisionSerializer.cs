using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XML_Project_Sem3.ClassToSerialize
{
    [Serializable]
    public class CountryDivisionSerializer
    {
        #region Public Properties

        [XmlAttribute]
        public string Capital { get; set; }

        [XmlArray("Cities")]
        [XmlArrayItem("City")]
        public List<CitySerializer> Cities { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        #endregion
    }
}
