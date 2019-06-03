using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2
{
    class Q2_1<T>
    {
        public void RemoveDuplicates()
        {
            MyLinkedList<int> myLinkedList = new MyLinkedList<int>();
            myLinkedList.Add(2);
            myLinkedList.Add(3);
            myLinkedList.Add(7);
            myLinkedList.Add(3);
            myLinkedList.Add(3);
                       

            foreach (var i in myLinkedList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"The length of the list is {myLinkedList.LengthOfList()}");

            // calls the new method to remove duplicates
            // Decided to add this method to my implementation of Linkedlist
            myLinkedList.RemoveDuplicates();

            Console.WriteLine("List after removing values");

            foreach (var i in myLinkedList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"The length of the list is {myLinkedList.LengthOfList()}");
        }
    }
}
