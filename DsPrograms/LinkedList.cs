using System;
using System.Collections.Generic;
using System.Text;

namespace DsPrograms
{
    public class LinkedList<T>where T:IComparable
    {
        public Node<T> head;

        //Method to search a particular word in the file
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

        //Imserting elements in front of the list
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

       //Returns int string  format from list
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
        public void Sort(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> temp = head;
            if(head == null || node.idata <= head.idata)
            {
                node.next = head;
                head = node;
            }
            else if(head.next == null && head.idata < node.idata)
            {
                head.next = node;
            }
            else
            {
                if(temp.next.idata > node.idata)
                {
                    node.next = temp.next;
                    temp.next = node;
                }
                else
                {
                    while(temp.next != null && temp.next.idata < node.idata)
                    {
                        temp = temp.next;
                    }
                    node.next = temp.next;
                    temp.next = node;
                }
            }

        }
        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);
            if(this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = this.head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public void Dequeue()
        {
            if(this.head == null)
            {
                Console.WriteLine("queue is empty");
            }
            Node<T> temp = this.head;
            this.head = this.head.next;
        }
        public int isEmpty()
        {
            if(this.head!= null)
            {
                return 1;

            }
            else
            {
                return 0;
            }
        }
        public string DequeuePlaindrome()
        {
            string rev = " ";
            while(this.head != null)
            {
                if(this.head == null)
                {
                    Console.WriteLine("Queue is Empty");
                }
                rev = this.head.data + rev;
                head = head.next;
            }
            return rev;

        }
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("List is empty.....");
            }
            while (temp != null)
            {
                
                Console.Write("\n"+temp.data);
                temp = temp.next;
            }
        }
    }
}
