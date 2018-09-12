using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account("name", 15000);
            ac.Display();
            ac.Debit(300);
            ac.Credit(3000);
            ac.Debit(200);
            ac.Display();
        }
    }

    public class Account
    {
        private string accountName;
        private int accountBalance;
        public void Credit(int amount)
        {
            Console.WriteLine("Credit {0} bath", amount);
        }
        public void Debit(int amount)
        {
            if (amount > accountBalance)
            {
                Console.WriteLine("Sory, there is not  enough monney");
            }
            else
            {
                accountBalance -= amount;
            }
            Console.WriteLine("Debit {0 , 10:C} bath", amount);
        }
        public void Display()
        {
            Console.WriteLine("Name: {0}, Balance: {1 , 10:C}", accountName, accountBalance);

        }
        public Account(string accoutntName, int amount)
        {
            this.accountName = accountName;
            this.accountBalance = amount;
        }
    }
}
