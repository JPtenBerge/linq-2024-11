using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class HydraulicPump
    {
        public void HandleHighTemperature(Reactor sender, HighTemperatureEventArgs args)
        {
            Console.WriteLine("[hydraulic] cooling! " + args.Temperature);
            sender.Temperature -= 15;
        }
    }
}
