using Shop.Database;
using Shop.Domain.Models;

namespace Shop.Application.Products
{
  public class CreateProduct
  {
    private ApplicationDbContext _context;
    public CreateProduct(ApplicationDbContext context)
    {
      _context = context;
    }

    public void Do(int id, string name, string description)
    {
      _context.Products.Add(new Product
      {
        Id = id,
        Name = name,
        Description = description
      });
    }
  }
}
