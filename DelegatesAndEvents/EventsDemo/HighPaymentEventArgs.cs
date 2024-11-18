using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    internal class HighPaymentEventArgs : EventArgs
    {
        public int HighPaymentAmount { get; set; }
    }
}
