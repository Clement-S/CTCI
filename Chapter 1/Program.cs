using System;
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

            //var test = new Q1_5();
            //var result = test.ReplaceSpaces(" Tokyo might be a nice place");
            //Console.WriteLine(result);

            //var test = new Q1_6();
            //const int imageSize = 5;
            //int[,] Image = new int[imageSize, imageSize] { { 1, 2, 3, 4, 5 },
            //                                                {6,7,8,9,10},
            //                                                {11,12,13,14,15 }, 
            //                                                {16,17,18,19,20}, 
            //                                                {21,22,23,24,25} };

            //Console.WriteLine("***********Initial Image Matrix**************");
            //test.OutputMatrix(Image, imageSize);
            //Console.WriteLine();

            //Console.WriteLine("***********Rotated Image Matrix**************");
            //var RotatedImage = test.RotateImageMatrix(Image, imageSize);
            //test.OutputMatrix(RotatedImage, imageSize);

            var test = new Q1_7();
            const int imageSize = 4;
            int[,] Image = new int[imageSize, imageSize] { { 1, 2, 3, 4 },
                                                           { 4, 5, 0, 6,},
                                                           {7, 0, 9, 4},
                                                           {6, 7, 2, 1 } };
            Console.WriteLine("***********Initial Image Matrix**************");
            test.OutputMatrix(Image, imageSize, imageSize);

            Console.WriteLine("***********Zeroed Image Matrix**************");
            test.FindZeroAndReplaceRowAndColumn(Image, imageSize, imageSize);
            Console.ReadLine();

        }
    }
}
