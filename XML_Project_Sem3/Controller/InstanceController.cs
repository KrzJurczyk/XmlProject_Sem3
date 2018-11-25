using XML_Project_Sem3.Config;
using XML_Project_Sem3.Interfaces;

namespace XML_Project_Sem3.Controller
{
    internal abstract class ControllerInstance
    {
        #region Private Fields

        private readonly ConfigProvider config;

        #endregion

        #region Protected Properties

        internal ConfigProvider Config { get => config; }


        #endregion

        #region Public Constructors

        public ControllerInstance(ConfigProvider config)
        {
            this.config = config;
        }

        #endregion

        #region Public Methods

        public abstract void GetInstance();

        #endregion
    }
}
