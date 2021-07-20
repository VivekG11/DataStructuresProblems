using System;
using System.Collections.Generic;
using System.Text;

namespace DsPrograms
{
    class BankCounter
    {
        public int bankBlnc = 5000;
        public void Queue()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            Console.WriteLine("Enter num of persons in queue :");
            int customers = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i<= customers; i++)
            {
                linkedList.Enqueue(i);
                OperationType();
                linkedList.Dequeue();

                
            }
        }

        public void OperationType()
        {
            string next = "Y";
            while(next == "Y" || next == "y")
            {
                Console.WriteLine("Enter an Option :");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("Enter amount to deposit :");
                        int depositAmount = Convert.ToInt32(Console.ReadLine());
                        bankBlnc = bankBlnc - depositAmount;
                        Console.WriteLine("BankBalance :"+bankBlnc);
                        break;
                    case 2:
                        Console.WriteLine("Enter amount to be withdrawn :");
                        int withDrawalAmount = Convert.ToInt32(Console.ReadLine());
                        bankBlnc = bankBlnc + withDrawalAmount;
                        Console.WriteLine("Bank Balance :"+bankBlnc);
                        break;

                }
                Console.WriteLine("Do you want to continue : (Y/N)");
                next = Console.ReadLine();
            }
        }
    }
}
