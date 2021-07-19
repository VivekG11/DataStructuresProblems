using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DsPrograms
{
    public class UnOrderedList
    {
        public static void UList()
        {
            string phrase = File.ReadAllText(@"C:\Users\VIVEK\source\repos\DsPrograms\words.txt");
            string[] array = phrase.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            LinkedList<string> list = new LinkedList<string>();
            for(int i = array.Length-1; i>= 0; i--)
            {
                list.InsertFront(array[i]);
            }

            list.Display();
            Console.WriteLine("Enter a word you want to search");
            string searchWord = Console.ReadLine();
            if(list.Search(searchWord))
            {
                list.DelNode(searchWord);
            }
            else
            {
                list.InsertFront(searchWord);
            }
            string text = list.ReturnString();
            File.WriteAllText(@"C:\Users\VIVEK\source\repos\DsPrograms\words.txt", phrase);
            list.Display();
           
        }
    }
}
