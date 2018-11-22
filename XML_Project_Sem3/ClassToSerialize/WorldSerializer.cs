using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XML_Project_Sem3.ClassToSerialize
{
    [Serializable]
    [XmlRoot(ElementName = "World")]
    public class WorldSerializer
    {
        #region Public Properties

        [XmlArray("Countries")]
        [XmlArrayItem("Country")]
        public List<CountrySerializer> Countries { get; set; }

        [XmlAttribute]
        public int Age { get; set; }

        #endregion
    }
}
