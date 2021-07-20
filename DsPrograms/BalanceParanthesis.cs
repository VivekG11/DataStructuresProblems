using System;
using System.Collections.Generic;
using System.Text;

namespace DsPrograms
{
    class BalanceParanthesis
    {
        char[] list;
        int top = 0;
        public static void Input()
        {
            Console.WriteLine("Enter an expression to validate : ");
            string input = Console.ReadLine();
            char[] exp = input.ToCharArray();
            BalanceParanthesis paranthesis = new BalanceParanthesis();
            bool result = paranthesis.isExpBalanced(exp);
            if(result)
            {
                Console.WriteLine("Entered Expression is a balanced expression");
            }
            else
            {
                Console.WriteLine("Not Balanced.");
            }

        }
        public bool Push(char x)
        {
            if(top == list.Length)
            {
                return false;
            }
            else
            {
                list[++top] = x;
                return true;
            }
        }

        public char Pop()
        {
            if(top == -1)
            {
                Console.WriteLine("UnderFLowError.");
                return '\0';
            }
            else
            {
                char element = list[top];
                top--;
                return element;
            }
        }

        public bool CheckChar(char ch1, char ch2)
        {
            if (ch1 == '[' && ch2 == ']')
                return true;
            else if (ch1 == '{' && ch2 == '}')
                return true;
            else if (ch1 == '(' && ch2 == ')')
                return true;
            else
                return false;
        }

        public bool isExpBalanced(char[] expression)
        {
            list = new char[expression.Length];
            bool flag = true;
            if (expression.Length == 0)
                return true;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == ')' || expression[i] == '{' || expression[i] == '[')
                {
                    Push(expression[i]);
                    flag = false;
                }

                if (expression[i] == ')' || expression[i] == '{' || expression[i] == '[')
                {
                    if (CheckChar(Pop(), expression[i]))
                        flag = true;
                    else
                        return false;
                }
            }
            return flag;
        }
    
    }
}
