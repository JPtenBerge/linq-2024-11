namespace Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reactor = new Reactor();
            var pump1 = new HydraulicPump();
            var pump2 = new PneumaticPump();

            reactor.HighTemperature += pump1.HandleHighTemperature;
            reactor.HighTemperature += pump2.HandleHighTemperature;

            while (true)
            {
                reactor.Split();
                Thread.Sleep(50);
            }
        }
    }
}
