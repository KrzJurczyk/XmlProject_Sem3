using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace XML_Project_Sem3.Controllers
{
    public sealed class SyntaxController
    {
        #region Private Fields

        private readonly Dictionary<int, string> nTs = new Dictionary<int, string>()
            { {1, "one"}, {2, "two"}, {3, "three" }, {4, "four" }, {5, "five"}
           , { 6, "six"}, {7, "seven"}, {8, "eight" }, {9, "nine" }, {0, "zero" }};

        #endregion

        #region Public Methods

        public void Validate(ref string userInput)
        {
            ReplaceNumber(ref userInput);
            var data = Regex.Replace(userInput, "[^\\w\\._]", ""); ;
        }

        #endregion

        #region Private Metohds

        private void ReplaceNumber(ref string stringToFIx)
        {
            var tmp = stringToFIx;
            string result = null;
            for (int i = 0; i < tmp.Length; i++)
            {
                if (int.TryParse(tmp[i].ToString(), out int c))
                {
                    result += tmp.Substring(i);
                    break;
                }

                int nc = c;
                nTs.TryGetValue(nc, out string nas);

                result += "n" + nas;
            }
        }

        #endregion
    }
}
