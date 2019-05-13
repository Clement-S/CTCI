using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1
{
    class Q1_1
    {
       public bool isUnique(string input)
        {
            var characters = input.ToCharArray();         

            for (int i = 0; i < characters.Length; i++)
            {
                for (int j = i + 1; j < characters.Length; j++)
                    if (characters[i] == characters[j])
                    {
                        return false;
                    }
            }
            return true;
        }
    }
}
