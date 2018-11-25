using XML_Project_Sem3.Config;
using XML_Project_Sem3.DataFillers;

namespace XML_Project_Sem3.Application
{
    public sealed class AppInstance
    {
        #region Private Fields

        private static AppInstance instance;
        private string defaultPathToSave;

        #endregion

        #region Private Constructors

        private AppInstance()
        {
        }

        #endregion

        #region Public Properites

        public static AppInstance Instance
        {
            get
            {
                if (instance == null)
                    instance = new AppInstance();
                return instance;
            }
        }

        #endregion

        #region Public Methods

        public void Start()
        {
            GetConfig();
        }

        #endregion

        #region Private Methods

        private void GetConfig()
        {
            var data = new DataProvider();
            var fillData = new ConfigFiller(data.GetConfigFile).FillConfig();


        }

        #endregion
    }
}
