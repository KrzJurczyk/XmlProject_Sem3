using System.IO;
using System.Xml;
using System.Xml.Serialization;
using XML_Project_Sem3.ClassToSerialize;
using XML_Project_Sem3.Creators;

namespace XML_Project_Sem3.Model
{
    public class ModelInstance
    {
        #region Privte Fields

        private readonly DataProvider data = new DataProvider();

        #endregion

        #region Public Methods

        public void StartCreateXml()
        {
            var xmlCreator = new WorldXmlCreator();
            xmlCreator.CreateWorld();
            
            XmlSerializer x = new XmlSerializer(typeof(WorldSerializer));
            TextWriter writer = new StreamWriter(data.PathToProject + @"\projektXml.xml");
            x.Serialize(writer, xmlCreator.World);
        }

        #endregion
    }
}
