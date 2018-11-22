using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XML_Project_Sem3.ClassToSerialize
{
    [Serializable]
    public class CountrySerializer
    {
        #region Public Properties

        [XmlAttribute]
        public string Capital { get; set; }

        [XmlArray("Partitions")]
        [XmlArrayItem("Partition")]
        public List<CountryPartitionSerializer> CountryPartitions { get; set; }

        [XmlAttribute]
        public string OfficialLanguages { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        #endregion
    }
}
