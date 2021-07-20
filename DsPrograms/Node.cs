using System;
using System.Collections.Generic;
using System.Text;

namespace DsPrograms
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;
        public int idata;
        public Node(T data)
        {
            this.data = data;
            next = null;
        }
    }
}
