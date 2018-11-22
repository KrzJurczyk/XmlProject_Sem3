using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XML_Project_Sem3.ClassToSerialize
{
    [Serializable]
    public class CitySerializer
    {
        #region Public Properties

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public int Population { get; set; }

        [XmlArray("Pubs")]
        [XmlArrayItem("Pub")]
        public List<string> Pubs { get; set; }

        #endregion
    }
}
