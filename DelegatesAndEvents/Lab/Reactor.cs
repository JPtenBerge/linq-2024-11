using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Reactor
    {
        public int Temperature { get; set; }

        public delegate void ReactorHighTemperatureHandler(Reactor reactor, HighTemperatureEventArgs args);

        public event ReactorHighTemperatureHandler HighTemperature;

        public void Split()
        {
            Console.WriteLine("SPLITTING... " + Temperature);
            Temperature += 10;

            if (Temperature > 400)
            {
                HighTemperature.Invoke(this, new HighTemperatureEventArgs { Temperature = Temperature });
            }
        }
    }
}
