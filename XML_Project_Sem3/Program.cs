using XML_Project_Sem3.Application;
using XML_Project_Sem3.Config;

namespace XML_Project_Sem3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = AppInstance.Instance;
            a.Start();
        }
    }
}
