# Notes

## Waar we naar toe werken

```cs
var filteredProducts = products.Where(x => x.Price > 50);
var filteredProducts = products.Where(delegate(x) { return x.Price > 50; });

// ontleed:
// - .Where() is een extension method op IEnumerable<T>
// - lambda en delegates voor x => x.Price > 50
// - var
// - generics
//  - + Func<T, bool>

```

## Generics

```cs
// dependency injection bij ASP.NET Core
builder.Services.AddSingleton<IProductService, ProductService>();

// serializatie
JsonSerializer.Deserialize<Product[]>(jsonString);

// DTOs
obj.Map<MijnDto>();

// mocken bij unittesten
new Mock<IMijnService>();

// overig
Nullable<int>
```


Ter vergelijking, Java heeft enkel compile-time generics (zie [type erasure](https://www.baeldung.com/java-type-erasure)), waardoor dat soort fancy notaties in Java niet beschikbaar zijn.

## Collections

`IEnumerable<>` deferred execution is bijv. waarom bij EF Core (ORM) vaak `.ToArray()`/`.ToList()` (of nog beter, de async varianten `.ToListAsync()`) wordt gebruikt:

```cs
context.Products.ToArray();
context.Products.ToList();

await context.Products.ToArrayAsync();
await context.Products.ToListAsync();
```

```cs
IEnumerable<T> // 90%
ICollection<T> // count add clear // 9%
IList<T> // 1%

List<T> - 95%
Dictionary<T> - volop
```


## Queryies in NetPad

```cs
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
var expensiveProducten = producten.Where(x => x.Prijs > 30M);
expensiveProducten.Dump();

class Product
{
    public string Beschrijving { get; set; }

    public decimal Prijs { get; set; }
}
```

```cs
var artists = new List<Artist>
{
    new() { Naam = "Ringo Starr", LocatieId = 8 },
    new() { Naam = "Bruno Mars", LocatieId = 4 },
    new() { Naam = "Michael Jackson", LocatieId = 15 },
    new() { Naam = "Kabouter Plop", LocatieId = 15 }
};
var locations = new List<Location>
{
    new() { Id = 4, Naam = "Hawaii" },
    new() { Id = 8, Naam = "Liverpool" },
    new() { Id = 15, Naam = "Belgie" },
};

// subquery
// var locationsWithNrOfArtists = from l
//                                in locations
//                                select new
//                                {
//                                   NaamVanLocatie = l.Naam,
//                                   NrOfArtists = (from a in artists where a.LocatieId == l.Id select a.Naam).Count()
//                                };

// join en group met let
var locationsWithNrOfArtists = from l
                               in locations
                               join a in artists on l.Id equals a.LocatieId
                               group l by new { l.Id, l.Naam } into groupedLocation
                               let countArtists = groupedLocation.Count()
                               where countArtists > 0
                               select new
                               {
                                    Naam = groupedLocation.Key.Naam,
                                    NrOfArists = countArtists
                               };
locationsWithNrOfArtists.ToList().Dump();

class Artist {
    public string Naam { get; set; }
    public int LocatieId { get; set; }
}
class Location {
    public int Id { get; set; }
    public string Naam { get; set; }
}





