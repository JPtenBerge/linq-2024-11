using ExtensionMethods.Utils;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bestaande classes uitbreiden

            // als de broncode van een class niet van jou

            var nu = new DateTime(2024, 11, 19, 9, 53, 56);
            Console.WriteLine(nu.ToString("d MMMM yyyy HH:mm"));
            Console.WriteLine(nu.ToPrettyString());

            // libraries die veel inhaken op extension methods:
            // - FluentAssertions
            // - Flurl
            // - ASP.NET Core middleware
        }
    }
}
