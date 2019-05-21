using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1
{
    class Q1_5
    {
        public string ReplaceSpaces(string input)
        {
            // using the built in .net method
            // var unspacedInput = input.Replace(" ", "%20");
            // return unspacedInput;

            // My implementation- spilt on space, then rejoin array with %sign
            var inputParts = input.Split(' ');

            StringBuilder unSpacedInput = new StringBuilder();
            for(var i = 0; i < inputParts.Length; i++)
            {
                if (i == 0)
                {
                    unSpacedInput.Append(inputParts[0]);
                    continue;
                }                   

                unSpacedInput.Append($"%20{inputParts[i]}");
            }

            return unSpacedInput.ToString();
           
        }
    }
}
