using System.IO;
using System.Xml.Serialization;
using XML_Project_Sem3.Interfaces;
using XML_Project_Sem3.Data.DataContainers;

namespace XML_Project_Sem3.Data.Hellpers
{
    internal class WorldFiller : IFillerProvider
    {
        #region Private Fields

        private string path;
        private WorldData data;

        #endregion

        #region Public Constructors

        public WorldFiller(string pathToFile)
        {
            path = pathToFile;
        }

        #endregion

        #region Public Properties

        public WorldData Data { get => data; }

        #endregion

        #region Public Methods

        public void Fill()
        {
            XmlSerializer x = new XmlSerializer(typeof(WorldData));
            using (TextReader reader = new StreamReader(path))
            {
                var obj = x.Deserialize(reader);
                data = (WorldData)obj;
            }
        }

        #endregion
    }
}