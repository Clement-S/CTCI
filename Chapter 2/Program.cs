using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var test = new Q2_1<int>();            
            //// create list with duplicates and removes the duplicates
            //test.RemoveDuplicates();

            var test = new Q2_2<int>();
            test.FindNthToLastElement(5);
            Console.ReadLine();

        }
    }
}
