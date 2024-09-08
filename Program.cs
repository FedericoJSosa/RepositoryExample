using RepositoryExample.Data;
using RepositoryExample.Domain;

IProductoRepository repository = new ProductReposityADO();
List<Product> lst=repository.GetProducts();

if (lst.Count == 0)
{
    Console.WriteLine("Sin producto");
}
else
{
    foreach (var p in lst)
    {
        Console.WriteLine(p);
    }
}