﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var test = new Q1_1();
            //var result = test.isUnique("clmentt");
            //Console.WriteLine(result);

            //var test = new Q1_2();
            //var result = test.ReverseString("clement");
            //Console.WriteLine(result);


            //var test = new Q1_3();
            //var result = test.RemoveDuplicate("clmenenctt").Trim();
            //Console.WriteLine(result);

            //var test = new Q1_4();
            //var result = test.AreAnagrams("tokyo", "kyoto");
            //Console.WriteLine(result);

            var test = new Q1_5();
            var result = test.ReplaceSpaces(" Tokyo might be a nice place");
            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
