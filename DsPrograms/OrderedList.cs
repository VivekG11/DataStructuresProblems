using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DsPrograms
{
     class OrderedList
    {
        public static void OrderList()
        {
            string str = File.ReadAllText(@"C:\Users\VIVEK\source\repos\DsPrograms\NumList.txt");
            string[] arr = str.Split(" ");
            LinkedList<int> linkedList = new LinkedList<int>();
            int[] numArray = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                int num = Convert.ToInt32(arr[i]);
                numArray[i] = num;
            }
             for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(numArray[i]+" ");
            }
             for(int i = 0; i < arr.Length; i++)
            {
                linkedList.Sort(numArray[i]);
            }

            linkedList.Display();
            Console.WriteLine("\nEnter a number to search :");
            int findNum = Convert.ToInt32(Console.ReadLine());
            if(linkedList.Search(findNum))
            {
                linkedList.DelNode(findNum);
            }
            else
            {
                linkedList.Sort(findNum);
            }
            string file = linkedList.ReturnString();
            File.WriteAllText(@"C:\Users\VIVEK\source\repos\DsPrograms\NumList.txt",file);
            linkedList.Display();
        }
    }
}
