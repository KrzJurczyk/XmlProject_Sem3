using System;

namespace XML_Project_Sem3.Model
{
    public class DataProvider
    {
        #region Privte Fields

        private readonly string pathToDesctop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private readonly string pathToProject = Environment.CurrentDirectory;
        
        #endregion

        #region Public Properties

        public string PathToDesctop => pathToDesctop;
        public string PathToProject => pathToProject;

        #endregion
    }
}
