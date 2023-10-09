using EFCoreApp.Data;
using EFCoreApp.Entities;

//delete
using (var context = new AppDbContext())
{
    var product = context.Products.FirstOrDefault(p => p.Id == productId);

    if (product != null)
    {
        context.Products.Remove(product);
        context.SaveChanges();
    }
}
//add

var products = new List<Product>
{
    new Product { Name = "Ürün 1", Price = 10.0, CategoryId = categoryId },
    new Product { Name = "Ürün 2", Price = 15.0, CategoryId = categoryId },
    // Diğer ürünler...
};

context.Products.AddRange(products);
context.SaveChanges();
}
//update
{
    var product = context.Products.FirstOrDefault(p => p.Id == productId);

    if (product != null)
    {
        product.Price = newPrice;
        context.SaveChanges();
    }
}