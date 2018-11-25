using XML_Project_Sem3.Config;
using XML_Project_Sem3.Model.Hellpers;

namespace XML_Project_Sem3.Application
{
    public sealed class AppInstance
    {
        #region Private Fields

        private static AppInstance instance;
        private readonly ConfigProvider config = new ConfigProvider();

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
            GetXmlFile();

            //var start = new ModelCreator();
            //start.StartCreateXml();
        }

        #endregion

        #region Private Methods

        private void GetXmlFile()
        {
            var a = new WorldFiller(config.DefaultPath + config.DefaultFile);
            a.Fill();
            var v = a.Data;
        }

        #endregion
    }
}
