namespace Chapter_2
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MyLinkedList<T> : IEnumerable<T>
    {
        private Node<T> Head;

        private Node<T> CurrentNode;

        public void Add(T data)
        {
            // create new node for incoming data
            Node<T> newNode = new Node<T>(data);

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            // set current node to the head
            CurrentNode = Head;

            // move through the nodes to find last node
            while (CurrentNode.Next != null)
            {
                // if next node is not null, move current Node to the next Node and recheck
                CurrentNode = CurrentNode.Next;
            }

            CurrentNode.Next = new Node<T>(data);
        }

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data)
            {
                Next = Head
            };
            Head = newNode;
        }

        public void Remove(T data)
        {
            if (Head.Data.Equals(data))
            {
                Head = Head.Next;
                return;
            }

            CurrentNode = Head;

            // move through the nodes 
            while (CurrentNode.Next != null)
            {
                // check the next node if it equals the data
                if (CurrentNode.Next.Data.Equals(data))
                {
                    CurrentNode.Next = CurrentNode.Next.Next;
                    return;
                }

                // if next node is not null, move current Node to the next Node and recheck
                CurrentNode = CurrentNode.Next;
            }
        }

        public void RemoveDuplicates()
        {
            Dictionary<T, bool> Buffer = new Dictionary<T, bool>();

            // Begin search from the First node
            Node<T> searchNode = Head;

            while (searchNode != null)
            {
                if (Buffer.ContainsKey(searchNode.Data))
                {
                    this.Remove(searchNode.Data);
                }
                else
                {
                    Buffer.Add(searchNode.Data, true);
                }
                searchNode = searchNode.Next;
            }
        }

        public Node<T> Find(T searchValue)
        {
            // Begin search from the First node
            Node<T> searchNode = Head;

            while (searchNode != null)
            {
                if (searchNode.Data.Equals(searchValue))
                {
                    return searchNode;
                }
                else
                {
                    searchNode = searchNode.Next;
                }
            }

            return null;
        }

        public T FindNthToLastElement(int nthToLastElement)
        {
            var length = LengthOfList();

            // in a single linked list, subtract the nth from the length to get the position when counting from the front.
            var numberOfNodeToReturn = length - nthToLastElement;

            var counter = 0;            

            Node<T> searchNode = Head;

            while (searchNode != null && counter <= numberOfNodeToReturn)
            {                
                if (counter == numberOfNodeToReturn)
                    return searchNode.Data;
                else
                {
                    counter++;
                    searchNode = searchNode.Next;
                }
                
            }

            return default(T);
        }

        public int LengthOfList()
        {
            var length = 0;

            Node<T> searchNode = Head;

            while (searchNode != null)
            {
                length++;
                searchNode = searchNode.Next;
            }

            return length;

        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> searchNode = Head;

            while (searchNode != null)
            {
                yield return searchNode.Data;

                searchNode = searchNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
