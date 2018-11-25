using System.IO;
using System.Xml.Serialization;
using XML_Project_Sem3.Data.DataContainers;

namespace XML_Project_Sem3.Serializers
{
    internal class MyXmlSerialize
    {
        #region Private Fields

        private WorldData data;
        private string pathToSave;

        #endregion

        #region Public Constructors

        public MyXmlSerialize(WorldData data, string path)
        {
            this.data = data;
            pathToSave = path;
        }

        #endregion

        #region Public Methods

        public void StartCreateXml()
        {
            XmlSerializer x = new XmlSerializer(typeof(WorldData));
            using(TextWriter writer = new StreamWriter(pathToSave))
                x.Serialize(writer, data);
        }

        #endregion
    }
}
