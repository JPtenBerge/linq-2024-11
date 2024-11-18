using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class PneumaticPump
    {
        public void HandleHighTemperature(Reactor sender, HighTemperatureEventArgs e)
        {
            Console.WriteLine("[pneumatic] cooling! " + e.Temperature);
            sender.Temperature -= 30;
        }
    }
}
