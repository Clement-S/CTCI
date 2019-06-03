using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2
{
    class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }

        public T Data;

        public Node<T> Next;
    }
}
