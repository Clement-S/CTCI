﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2
{
    class Q2_2<T>
    {
        public void FindNthToLastElement(int nthElement)
        {
            MyLinkedList<int> myLinkedList = new MyLinkedList<int>();
            myLinkedList.Add(2);
            myLinkedList.Add(3);
            myLinkedList.Add(7);
            myLinkedList.Add(8);
            myLinkedList.Add(98);
            myLinkedList.Add(34);

            foreach (var i in myLinkedList)
            {
                Console.WriteLine(i);
            }

            //Added this function to my implementation of Linkedlist
            var value = myLinkedList.FindNthToLastElement(nthElement);

            Console.WriteLine($"The {nthElement} to Last element of the list is { value }");
        }
    }
}

    
