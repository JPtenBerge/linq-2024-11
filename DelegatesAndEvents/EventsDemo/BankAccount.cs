using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    internal class BankAccount
    {
        public int Balance { get; set; }

        public delegate void HighPaymentEventHandler(BankAccount sender, HighPaymentEventArgs args);

        public event HighPaymentEventHandler HighPayment;

        public BankAccount(int initialBalance)
        {
            Balance = initialBalance;
        }

        public void Pay(int amount)
        {
            Balance -= amount;

            Console.WriteLine("Even wat betalen! " + amount);

            if (amount > 100_000)
            {
                // event oproepen
                HighPayment.Invoke(this, new HighPaymentEventArgs { HighPaymentAmount = amount });
            }
        }
    }
}
