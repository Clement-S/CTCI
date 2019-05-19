using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1
{
    class Q1_2
    {
        public string ReverseString(string data)
        {
            var charData = data.ToCharArray();
            StringBuilder reversedString = new StringBuilder();
            for(var i = charData.Length; i > 0; i--)
            {
                reversedString.Append(charData[i-1]);
            }
            return reversedString.ToString();
        }
    }
}
