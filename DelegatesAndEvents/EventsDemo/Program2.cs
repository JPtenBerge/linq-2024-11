using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    public class Program2
    {

        public static void Main(string[] args)
        {
            var account = new BankAccount(17_000_000);
            var besteAccountant = new Accountant();

            account.HighPayment += (sender, args) =>
            {
                Console.WriteLine("Hier de accountant! Betaling: " + args.HighPaymentAmount);
            };
            account.HighPayment += besteAccountant.HandleHighPayment;

            // Observer/Observable  / pub/sub

            account.Pay(200);
            account.Pay(2_000_000);

            Console.WriteLine("Account balans is nu " + account.Balance);

        }
    }
}
