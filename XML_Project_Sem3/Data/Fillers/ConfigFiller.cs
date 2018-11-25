using System.IO;
using System.Xml.Serialization;
using XML_Project_Sem3.Interfaces;
using XML_Project_Sem3.Data.DataContainers;

namespace XML_Project_Sem3.Data.Hellpers
{
    internal class ConfigFiller : IFillerProvider
    {
        #region Private Fields

        private string path;
        private string defPath;
        private string defFile;

        #endregion

        #region Public Constructors

        public ConfigFiller(string pathToConfig)
        {
            path = pathToConfig;
        }

        #endregion

        #region Public Properties

        public string DefPath { get => defPath; }
        public string DefFile { get => defFile; }

        #endregion

        #region Public Methods

        public void Fill()
        {
            ConfigData data;
            XmlSerializer x = new XmlSerializer(typeof(ConfigData));
            using (TextReader reader = new StreamReader(path))
            {
                var obj = x.Deserialize(reader);
                data = (ConfigData)obj;
            }
            defPath = data.DefaultPath.Path;
            defFile = data.DefaultPath.FileName;
        }

        #endregion
    }
}
