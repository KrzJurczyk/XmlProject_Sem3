using XML_Project_Sem3.Config;
using XML_Project_Sem3.Interfaces;

namespace XML_Project_Sem3.Controller
{
    internal class ModifyController : ControllerInstance
    {
        #region Private Fields

        private IModel userData;

        #endregion

        #region Public Constructrs

        public ModifyController(ConfigProvider config) : base(config)
        {
        }

        #endregion

        #region Public Methods

        public override void GetInstance()
        {
            userData.Initialize();
        }

        #endregion
    }
}
