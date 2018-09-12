//Requirement
//1. มี balance แยกระหว่าง debit, credit /
//2. สามารถรวมยอดเพื่อเพิ่มวงเงินในการใช้จ่ายแต่ละครั้งได้ /
//3. สามารถแสดงยอดคงเหลือสำหรับแต่ละ balance ได้/
//4. ในกรณีใช้วงเงินเกินจากแต่ละ balance ที่มี ให้เลือกว่าจะใช้จาก balance ใดให้หมดวงเงินก่อน

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
            Account ac = new Account("pakon", 10000, 10000);
            ac.Display();
            ac.Buy(15000); //buy TV 15000 bath
            ac.Display();
        }
    }

    public class Account
    {
        private string accountName;
        //private int accountBalance;
        private int credit;
        private int debit;

        public void Credit(int credit)
        {
            Console.WriteLine("Credit {0} bath", credit);
        }

        public void Debit(int debit)
        {
            Console.WriteLine("Credit {0} bath", debit);
        }
        // Function Buy

        public void Buy(int buy)
        {
            if(credit >= buy)
            {
                credit = credit - buy;
            }
            else
            {
                //debit = debit + (credit - buy);
                //credit = 0;
                Console.WriteLine("Please select a purchase method : [1] Credit,  [2] Debit");
                int s = Convert.ToInt16(Console.ReadLine());
                switch (s)
                {
                    case 1:
                            debit = debit + (credit - buy);
                            credit = 0;
                            break;
                    case 2: Console.WriteLine("You owe the bank {0}", debit);
                            credit = credit + (debit - buy);
                            debit = -debit;
                            break;
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Name: {0}, Balance: Credit = {1 , 10:C} , Debit = {2 , 10:C}", accountName, credit, debit);
        }
        public Account(string accountName, int credit, int debit)
        {
            this.accountName = accountName;
            this.credit = credit;
            this.debit = debit;
        }
    }
}