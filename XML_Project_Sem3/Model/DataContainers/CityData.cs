using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using XML_Project_Sem3.Interfaces;

namespace XML_Project_Sem3.Model.DataContainers
{
    [Serializable]
    public class CityData : IDataProvider
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
