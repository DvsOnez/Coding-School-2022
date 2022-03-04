using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Reverser
    {
        public string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = string.Empty;
            for (int i = cArray.Length - 1; i >= 0; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

    }
}
