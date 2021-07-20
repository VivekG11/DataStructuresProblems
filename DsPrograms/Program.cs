using System;

namespace DsPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structures problems....");
            Console.WriteLine("Enter a number to perform Particular operation..");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    UnOrderedList.UList();
                    break;
                case 2:
                    OrderedList.OrderList();
                    break;
                case 3:
                    BalanceParanthesis.Input();
                    break;
                case 4:
                    BankCounter counter = new BankCounter();
                    counter.Queue();
                    break;
            }
           
        }
    }
}
