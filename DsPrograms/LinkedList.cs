using System;
using System.Collections.Generic;
using System.Text;

namespace DsPrograms
{
    public class LinkedList<T>
    {
        public Node<T> head;

        public bool Search(T val)
        {
            Node<T> temp = this.head;
            while(temp!= null)
            {
                if(temp.data.Equals(val))
                {
                    Console.WriteLine("Word found...");
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        public void InsertFront(T value)
        {
            Node<T> node = new Node<T>(value);
            node.next = this.head;
            this.head = node;
        }
        public void DelNode(T data)
        {
            Node<T> temp = head;
            while(temp.next != null)
            {
                if(temp.next.data.Equals(data))
                {
                    Console.WriteLine("Delete  data....");
                    temp.next = temp.next.next;
                    break;
                }
                else
                {
                    temp = temp.next;
                }
            }
        }

        public void Display()
        {
            Node<T> temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("List is empty.....");
            }
            while(temp != null)
            {
                Console.WriteLine("Nodes in the List are.......");
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public string ReturnString()
        {
            string str = "";
            Node<T> current = head;
            if(head != null)
            {
                str += current.data;
                current = current.next;
                while(current != null)
                {
                    str = str + " " + current.data;
                    current = current.next;
                }
                return str;
            }
            else
            {
                Console.WriteLine("Empty");
                return default;
            }
        }
    }
}
