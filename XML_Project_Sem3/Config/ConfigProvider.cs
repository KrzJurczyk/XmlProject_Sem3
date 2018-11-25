using XML_Project_Sem3.Model.Hellpers;

namespace XML_Project_Sem3.Config
{
    internal class ConfigProvider
    {
        #region Private Fields

        private string defaultPath;
        private string defaultFile;

        #endregion

        #region Public Constructors

        public ConfigProvider()
        {
            var path = new PathProvider();
            var helper = new ConfigFiller(path.GetConfigPath);
            helper.Fill();
            defaultPath = helper.DefPath;
            defaultFile = helper.DefFile;
        }

        #endregion

        #region Public Properties

        public string DefaultPath { get => defaultPath; }
        public string DefaultFile { get => defaultFile; }

        #endregion
    }
}
