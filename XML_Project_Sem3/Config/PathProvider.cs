using System;

namespace XML_Project_Sem3.Config
{
    internal class PathProvider
    {
        #region Privte Fields

        private readonly string pathToDesctop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private readonly string pathToProject = Environment.CurrentDirectory;
        private const string configFile = @"\Config\config.xml";

        #endregion

        #region Public Properties

        public string PathToDesctop => pathToDesctop;
        public string PathToProject => pathToProject;
        public string GetConfigPath => pathToProject + configFile;

        #endregion
    }
}
