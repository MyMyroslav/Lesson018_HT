using System;
namespace Lesson018_HT
{
    public abstract class BankAccount
    {
        public delegate void NotifyAccountChangeHandler(string message);
        public event NotifyAccountChangeHandler NotifyAccountChange;
        //{
        //    add => NotifyAccountChange += value;
        //    remove => NotifyAccountChange -= value;
        //}
        
        public decimal money2;
        public decimal AllMoney { get; set; }

        public sealed class CreditAccount : BankAccount
        {
            decimal creditMoney = 300;

            public override decimal GetMoney(decimal money)
            {
                creditMoney += money;
                //Console.WriteLine($"Your credit money: {creditMoney}");
                NotifyAccountChange.Invoke($"Your credit money: {creditMoney}");
                return creditMoney;
            }

            public override void SetMoney(decimal money)
            {
                if (money == creditMoney)
                {
                    //Console.WriteLine($"Your credit money: {creditMoney - money}");
                    NotifyAccountChange?.Invoke($"Your credit money: {creditMoney - money}");
                    //Console.WriteLine($"Your main money: {money2}");
                    NotifyAccountChange?.Invoke($"Your main money: {money2}"); 
                }
                else if (money > creditMoney)
                {
                    //Console.WriteLine($"Your credit money: {creditMoney - creditMoney}");
                    NotifyAccountChange?.Invoke($"Your credit money: {creditMoney - creditMoney}");
                    //Console.WriteLine($"Your main money: {money2 + money - creditMoney}");
                    NotifyAccountChange?.Invoke($"Your main money: {money2 + money - creditMoney}");

                }
                else if (money < creditMoney)
                {
                    //Console.WriteLine($"Your credit money: {creditMoney - money}, you should to pay: {creditMoney - creditMoney + money}");
                    NotifyAccountChange?.Invoke($"Your credit money: {creditMoney - money}, you should to pay: {creditMoney - creditMoney + money}");
                    //Console.WriteLine($"Your main money: {money2}");
                    NotifyAccountChange?.Invoke($"Your main money: {money2}");
                }
            }

        }
        internal sealed class DepositeAccount : BankAccount
        {
            decimal DepositeMoney = 1000;

            public override void SetMoney(decimal money)
            {
                DepositeMoney += money + money * (decimal)0.1;
                //Console.WriteLine($"On deposite account {DepositeMoney}");
                NotifyAccountChange.Invoke($"Now deposite money equal: {DepositeMoney}");
            }

            public override decimal GetMoney(decimal money)
            {
                if (money <= DepositeMoney && money > 0)
                {
                    DepositeMoney -= money;
                    //Console.WriteLine($"Now deposite money equal: {DepositeMoney}");
                    NotifyAccountChange.Invoke($"Now deposite money equal: {DepositeMoney}");
                    return DepositeMoney;
                }
                else
                {
                    NotifyAccountChange.Invoke("There are not that money!");
                    //Console.WriteLine("There are not that money!");
                    return -1;
                }
            }


        }
        //public static BankAccount MakeCreditAccount();
        //public static BankAccount MakeDepositeAccount();
        public abstract void SetMoney(decimal money);
        public abstract decimal GetMoney(decimal money);
        public BankAccount()
        {
        }
    }
}


