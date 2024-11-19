namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Product> producten = new List<Product>
            {
                new Product { Beschrijving = "Kopje", Prijs = 0.90M },
                new Product { Beschrijving = "Lepeltje", Prijs = 0.40M },
                new Product { Beschrijving = "Webcam", Prijs = 69.95M },
                new Product { Beschrijving = "Powercube", Prijs = 30.50M },
                new Product { Beschrijving = "Muis", Prijs = 8.50M },
                new Product { Beschrijving = "Toetsenbord", Prijs = 7.80M },
                new Product { Beschrijving = "Meeting owl pro", Prijs = 1400M },
                new Product { Beschrijving = "Laptop", Prijs = 2700M },
                new Product { Beschrijving = "Glas", Prijs = 0.80M },
                new Product { Beschrijving = "Sprite", Prijs = 1.70M },
                new Product { Beschrijving = "Snotdoekjes", Prijs = 0.03M },
                new Product { Beschrijving = "Afstandsbediening", Prijs = 32.40M }
            };

            // Language-INtegrated Query
            // - sorteren .OrderBy() .ThenBy() .OrderByDescending() .ThenByDescending() 
            // - groeperen .GroupBy()
            // - selecteren - mapping  .Select()
            // - filteren .Where()
            // - paginatie .Skip(..)  .Take(10)
            // - tellen:
            //   - .Count()
            //   - .Any() - sneller voor "is er iets"
            //   - .Sum()


            // LINQ extension methods
            //foreach (var item in producten.Skip(2).Take(4).OrderBy(x => x.Beschrijving).ThenBy(x => x.Prijs))
            //{
            //    Console.WriteLine("product: " + item.Beschrijving + " kost " + item.Prijs);
            //}

            //Console.WriteLine("totaal aantal producten: " + producten.Count(x => x.Prijs > 50));
            //Console.WriteLine("totale bedrag van alles: " + producten.Sum(x => x.Prijs));

            //Console.WriteLine("is er minimaal 1 product? " + producten.Any());
            //Console.WriteLine("is er minimaal 1 product? " + (producten.Count() > 0));

            //Console.WriteLine("===================");

            //var expensiveProducten = producten.Where(x => x.Prijs > 50);
            //foreach (var item in expensiveProducten)
            //{
            //    Console.WriteLine("duur product: " + item.Beschrijving + " kost " + item.Prijs);
            //}

            // LINQ comprehension syntax - vind ik fijner zodra de complexiteit van je query > 10 ligt
            var prijsFilter = 50M;
            //var expensiveProducten = from p
            //                         in producten
            //                         where p.Prijs > prijsFilter
            //                         orderby p.Beschrijving
            //                         select p;

            var expensiveProducten = producten.Where(x => x.Prijs > prijsFilter);

            prijsFilter = 3M;

            foreach (var item in expensiveProducten)
            {
                Console.WriteLine("met comprehension product: " + item.Beschrijving + " kost " + item.Prijs);
            }

            // first vs firstordefault - de eerste geeft error als er niks in zit, de tweede de default value
            // single vs singleordefault - de eerste geeft error als er niks in zit, de tweede de default value
            // first vs single? single checkt of hij ook echt maar 1 resultaat krijgt
            var eerste = producten.SingleOrDefault();
            Console.WriteLine(eerste.Beschrijving);

//            DataSource.Products.First()
//DataSource.Products.FirstOrDefault()
//DataSource.Products.Single()
//DataSource.Products.SingleOrDefault()




        }
    }

    class Product
    {
        public string Beschrijving { get; set; }

        public decimal Prijs { get; set; }
    }
}
