using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1
{
    class Q1_3
    {
        public string RemoveDuplicate(string input)
        {
            var characters = input.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                for (int j = i + 1; j < characters.Length; j++)
                    if (characters[i] == characters[j])
                    {
                        characters[j] = '\0';                        
                    }
            }
            return new string(characters);

            // Remove duplicate chars using string concats.
            // ... Store encountered letters in this string.
            //string result = "";

            //foreach (char value in key)
            //{
            //    // See if character is in the result already.
            //    if (result.IndexOf(value) == -1)
            //    {
            //        // Append to the result.
            //        result += value;
            //    }
            //}
            //return result;
        }
    }
}

