using System.IO;
using System.Xml.Serialization;
using XML_Project_Sem3.DataContainers;

namespace XML_Project_Sem3.DataFillers
{
    public class ConfigFiller
    {
        #region Private Fields

        private string pathToConfig;
        private ConfigData config = new ConfigData();

        #endregion

        #region Public Constructors


        public ConfigFiller(string pathToConfig)
        {
            this.pathToConfig = pathToConfig;
        }

        #endregion

        #region Public Methods

        public ConfigData FillConfig()
        {
            var data = new ConfigData();
            XmlSerializer x = new XmlSerializer(typeof(ConfigData));
            using (TextReader reader = new StreamReader(pathToConfig))
            {
                var a = (ConfigData)x.Deserialize(reader);
                data.DefaultPath.FileName = a.DefaultPath.FileName;
                data.DefaultPath.Path = a.DefaultPath.Path;
            }
            return data;
        }


        #endregion
    }
}
