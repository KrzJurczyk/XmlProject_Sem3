using System;
using System.Collections.Generic;

namespace XML_Project_Sem3.Config
{
    public sealed class SyntaxController
    {
        #region Private Fields

        private readonly Dictionary<int, string> nTs = new Dictionary<int, string>()
            { {1, "one"}, {2, "two"}, {3, "three" }, {4, "four" }, {5, "five"}
           , { 6, "six"}, {7, "seven"}, {8, "eight" }, {9, "nine" }, {0, "zero" }};

        #endregion

        #region Public Methods

        public string UserInput()
        {
            var rl = Console.ReadLine();
            return ReplaceNumber(rl);
        }

        #endregion

        #region Private Metohds

        private string ReplaceNumber(string stringToFIx)
        {
            var tmp = stringToFIx;
            string result = null;
            for (int i = 0; i < tmp.Length; i++)
            {
                if (int.TryParse(tmp[i].ToString(), out int c))
                {
                    result += tmp.Substring(i).ToUpper();
                    break;
                }

                int nc = c;
                nTs.TryGetValue(nc, out string nas);

                result += "num_" + nas;
            }
            return result;
        }

        #endregion
    }
}
