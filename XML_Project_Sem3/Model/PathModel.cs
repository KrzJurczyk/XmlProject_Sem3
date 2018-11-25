using System;
using System.IO;
using XML_Project_Sem3.Config;
using XML_Project_Sem3.Interfaces;

namespace XML_Project_Sem3.Model
{
    internal class PathModel : IModel
    {
        #region Private Fields

        private string defaultPath;
        private string defaultFile;
        private string pathToSave;
        private string pathToLoad;

        private string fileName;

        #endregion

        #region Public Constructors

        public PathModel(ConfigProvider config)
        {
            defaultPath = config.DefaultPath;
            defaultFile = config.DefaultFile;
        }

        #endregion

        #region Public Properites

        public string FilePathToSave => pathToSave + fileName;

        #endregion

        #region Public Methods

        public void Initialize()
        {
            SetPath();
        }

        #endregion

        #region Private Methods

        private void SetPath()
        {
            Console.WriteLine("Default path, press 1");
            Console.WriteLine("Customer path, press 2");
            var uinp = Console.ReadLine();

            if (!int.TryParse(uinp, out int nr))
            {
                Console.WriteLine("Incorrect! Try again.");
                SetPath();
            }

            switch (nr)
            {
                case 1:
                    SetFile(defaultPath);
                    break;
                case 2:
                    Console.Write("Input path: ");
                    var inp = Path.GetFullPath(Console.ReadLine());
                    if(System.IO.Directory.Exists(inp))
                    {
                        SetFile(inp);
                        break;
                    }
                    Console.Write("Incorrect path value! Path will be set as default!");
                    SetFile(defaultPath);
                    break;
                default:
                    SetFile(defaultPath);
                    break;
            }
        }

        private void SetFile(string path)
        {
            pathToSave = path;

            Console.WriteLine("Set file name.");
            Console.WriteLine("Default file name, press 1");
            Console.WriteLine("Customer file name, press 2");
            var uinp = Console.ReadLine();

            if (!int.TryParse(uinp, out int nr))
            {
                Console.WriteLine("Incorrect! Try again.");
                SetPath();
            }

            switch (nr)
            {
                case 1:
                    fileName = defaultFile;
                    break;
                case 2:
                    Console.Write("Write file name: ");
                    fileName = Console.ReadLine();
                    break;
                default:
                    fileName = defaultFile;
                    break;
            }

            fileName += ".xml";
        }

        #endregion
    }
}
