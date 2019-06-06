using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2
{
    class Q2_3<T>
    {
        public void DeleteNodeInMiddle(Node<int> nodeToDelete)
        {            
            MyLinkedList<int> myLinkedList = new MyLinkedList<int>();
            myLinkedList.Add(2);
            myLinkedList.Add(3);
            myLinkedList.Add(7);
            myLinkedList.Add(8);
            myLinkedList.Add(98);

            Console.WriteLine("Current values in the Linked List are:");
            foreach (var i in myLinkedList)
            {
                Console.WriteLine(i);
            }

            // call delete function in mylinkedlist class implementation
            myLinkedList.Remove(nodeToDelete.Data);

            Console.WriteLine("Values in the Linked List after delete:");
            foreach (var i in myLinkedList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
