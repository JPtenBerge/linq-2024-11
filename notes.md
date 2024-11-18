# Notes

## Waar we naar toe werken

```cs
var filteredProducts = products.Where(x => x.Price > 50);
```

## Generics

```cs
// dependency injection bij ASP.NET Core
builder.Services.AddSingleton<IProductService, ProductService>();

// serializatie
JsonSerializer.Deserialize<Product[]>(jsonString);

// DTOs
obj.Map<MijnDto>();

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








