using System;
using System.Collections.Generic;
using System.Text;

namespace DsPrograms
{
    class PalindromeChecker<T>
    {
        public string input;
        public void Palindrome()
        {
            LinkedList<char> linkedList = new LinkedList<char>();
            Console.WriteLine("Enter a string to check :");
            input = Console.ReadLine();
            for(int i = 0; i < input.Length; i++)
            {
                linkedList.Enqueue(input[i]);
            }
            linkedList.Display();
            string revString = linkedList.DequeuePlaindrome();
            if(input == revString)
            {
                Console.WriteLine("\nEntered input is a Palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome.");
            }
        }
    }
}
