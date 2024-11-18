public class Program
{
    static List<Product> products = new List<Product>
        {
            new Product { Beschrijving = "Sprite", Prijs = 1.40M },
            new Product { Beschrijving = "Muis", Prijs = 16M },
            new Product { Beschrijving = "Scherm", Prijs = 270M },
            new Product { Beschrijving = "Glas", Prijs = 1.80M },
            new Product { Beschrijving = "Lepel", Prijs = 0.40M },
            new Product { Beschrijving = "Kopje", Prijs = 0.90M },
            new Product { Beschrijving = "Laptop", Prijs = 2700M }
        };

    public static void Main(string[] args)
    {


        //var mijnDelegate = delegate (int eerste, string tweede)
        //{
        //    Console.WriteLine("hallo daar!" + tweede);
        //};
        //mijnDelegate.Invoke(42, "hoi");
        //mijnDelegate.Invoke(42, "doei");


        var mijnDelegate = (int eerste, string tweede) =>
        {
            Console.WriteLine("hallo daar!" + tweede);
        };
        mijnDelegate.Invoke(42, "hoi");
        mijnDelegate.Invoke(42, "doei");


        // delegates
        FilterProductsByBeschrijving("e");
        FilterCheapProducts(10);
        FilterProducts(delegate (Product product)
        {
            return product.Prijs < 10;
        });
        FilterProducts(p => p.Prijs < 10);
    }

    public static void FilterProductsByBeschrijving(string beschrijving)
    {
        foreach (Product product in products)
        {
            if (product.Beschrijving.Contains(beschrijving))
            {
                Console.WriteLine("Product matcht beschrijving: " + product.Beschrijving);
            }
        }
    }

    public static void FilterCheapProducts(decimal maximumPrijs)
    {
        foreach (Product product in products)
        {
            if (product.Prijs < maximumPrijs)
            {
                Console.WriteLine("Product is goedkoop: " + product.Beschrijving + " kost maar " + product.Prijs);
            }
        }
    }

    // 3 typen delegates:
    // - Predicate
    // - Action
    // - Func
    internal static void FilterProducts(Predicate<Product> pred)
    {
        foreach (Product product in products)
        {
            if (pred.Invoke(product))
            {
                Console.WriteLine("Product matcht: " + product.Beschrijving + " kost " + product.Prijs);
            }
        }
    }
}




class Product
{
    public string Beschrijving { get; set; }

    public decimal Prijs { get; set; }
}



// events