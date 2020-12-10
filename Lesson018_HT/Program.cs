using System;
using static Lesson018_HT.BankAccount;
namespace Lesson018_HT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CreditAccount creditAccount = new CreditAccount();
            creditAccount.NotifyAccountChange += DisplayMessage;
            creditAccount.money2 = 1000;
            creditAccount.SetMoney(115);
            Console.WriteLine("How much money you want to take for credit ? Enter sum:");
            int creditSum = int.Parse(Console.ReadLine());
            creditAccount.GetMoney(creditSum);
            Console.WriteLine(" ");
            
            DepositeAccount depositeAccount = new DepositeAccount();
            depositeAccount.NotifyAccountChange += DisplayMessage;
            depositeAccount.SetMoney(1200);
            depositeAccount.GetMoney(300);
        }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
