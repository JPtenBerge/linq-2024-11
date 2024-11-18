using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    internal class Accountant
    {
        public void HandleHighPayment(BankAccount sender, HighPaymentEventArgs args)
        {
            Console.WriteLine("Hier de externe accountant! Betaling: " + args.HighPaymentAmount);
        }
    }
}
