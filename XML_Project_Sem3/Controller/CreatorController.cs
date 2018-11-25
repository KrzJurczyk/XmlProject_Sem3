using XML_Project_Sem3.Config;
using XML_Project_Sem3.Model;
using XML_Project_Sem3.Serializers;

namespace XML_Project_Sem3.Controller
{
    internal class CreatorController : ControllerInstance
    {
        #region Private Fields

        private CreatorModel userData = new CreatorModel();
        private PathModel filePath;

        #endregion

        #region Public Constructrs

        public CreatorController(ConfigProvider config) : base(config)
        {
            filePath = new PathModel(config);
        }

        #endregion

        #region Public Methods

        public override void GetInstance()
        {
            filePath.Initialize();
            userData.Initialize();
            var data = userData.World;
            var serializer = new MyXmlSerialize(data, filePath.FilePathToSave);
            serializer.StartCreateXml();
        }

        #endregion
    }
}
