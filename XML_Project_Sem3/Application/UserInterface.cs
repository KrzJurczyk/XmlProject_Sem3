using System;
using XML_Project_Sem3.Config;
using XML_Project_Sem3.Controller;

namespace XML_Project_Sem3.Application
{
    internal class UserInterface
    {
        #region Public Methods

        public void HelloMethod(ConfigProvider config)
        {
            Console.WriteLine("Turbo console app!");
            SwitchOption(config);
        }

        #endregion

        #region Private Methods

        private void SwitchOption(ConfigProvider config)
        {
            Console.WriteLine("To create an xml, press 1");
            Console.WriteLine("To modify an xml, press 2");
            Console.WriteLine("To end, press 3");
            var uinp = Console.ReadLine();

            if (!int.TryParse(uinp, out int nr))
            {
                Console.WriteLine("Incorrect! Try again.");
                SwitchOption(config);
            }

            switch (nr)
            {
                case 1:
                    var inst = new CreatorController(config);
                    inst.GetInstance();
                    break;
                case 2:
                    Console.WriteLine("!!!!!!!");
                    Console.WriteLine("Unsupported yet.");
                    Console.WriteLine("!!!!!!!");
                    SwitchOption(config);
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("!!!!!!!");
                    Console.WriteLine("Invalid option number!");
                    Console.WriteLine("!!!!!!!");
                    SwitchOption(config);
                    break;
            }

        }

        #endregion
    }
}
