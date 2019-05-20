using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1
{
    class Q1_4
    {
        public bool AreAnagrams(string firstInput, string secondInput)
        {
            // If the strings lenght are different then they cannot be anagrams
            if (firstInput.Length != secondInput.Length)
                return false;

            var firstInputCharacters = firstInput.ToCharArray();
            Array.Sort(firstInputCharacters, new CaseInsensitiveComparer());

            var secondInputCharacters = secondInput.ToCharArray();
            Array.Sort(secondInputCharacters, new CaseInsensitiveComparer());

            for(var i = 0; i < firstInputCharacters.Length; i++)
            {
                if (firstInputCharacters[i] != secondInputCharacters[i])
                    return false;
            }

            return true;
        }
    }
}
