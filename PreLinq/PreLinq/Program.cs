namespace PreLinq
{
    internal class Program
    {

        private static object lockObj = new { };

        static void Main(string[] args)
        {
            var mijnObj = new
            {
                Naam = "JP",
                Leeftijd = 37
            };
            Console.WriteLine(mijnObj.Naam);

            int getal = 4;
            var getal2 = GeefKleinGetal(); // lazy keyword

            // 3 plekken:
            // - heel veel bij LINQ: groeperen/sorteren/selecten
            // - EF Core - configuratie tabellen/constraints
            // - lockobjecten

            var tupel = GeefNogIetsTerug();


            lock (lockObj)
            {
            }

        }

        static (int Getal, string Tekstje) GeefNogIetsTerug()
        {
            return (42, "hoi");
        }

        static short GeefKleinGetal()
        {
            return 3;
        }
    }
}
