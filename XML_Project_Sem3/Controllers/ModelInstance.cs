using System.IO;
using System.Xml.Schema;
using System.Xml.Serialization;
using XML_Project_Sem3.ClassToSerialize;
using XML_Project_Sem3.Creators;

namespace XML_Project_Sem3.Controller
{
    public class ControllerInstance
    {
        #region Privte Fields

        private readonly DataProvider data = new DataProvider();

        #endregion

        #region Public Methods

        public void StartCreateXml()
        {
            var xmlCreator = new XmlCreator();
            xmlCreator.CreateWorld();

            XmlSerializer x = new XmlSerializer(typeof(WorldSerializer));
            TextWriter writer = new StreamWriter(data.PathToProject + @"\projektXml.xml");
            x.Serialize(writer, xmlCreator.World);
        }

        #endregion
    }
}
