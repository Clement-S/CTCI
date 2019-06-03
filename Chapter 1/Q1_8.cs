using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1
{
    static class Q1_8
    {
        public static bool IsRotation(this string s1, string s2)
        {
            // There lengths must be same 
            // concat of s1 + s1 should have s2 has a substring
            return (s1.Length == s2.Length)  && ((s1 + s1).Contains(s2));
        }
    }
}
