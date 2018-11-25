using XML_Project_Sem3.Config;
using XML_Project_Sem3.Data.Hellpers;

namespace XML_Project_Sem3.Application
{
    public sealed class AppInstance
    {
        #region Private Fields

        private static AppInstance instance;
        private readonly ConfigProvider config = new ConfigProvider();
        private UserInterface ui;

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
            ui = new UserInterface();
            ui.HelloMethod(config);
        }

        #endregion
    }
}
