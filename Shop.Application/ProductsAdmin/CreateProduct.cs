using Shop.Database;
using Shop.Domain.Models;
using System.Threading.Tasks;

namespace Shop.Application.ProductsAdmin
{
  public class CreateProduct
  {
    private ApplicationDbContext _context;
    public CreateProduct(ApplicationDbContext context)
    {
      _context = context;
    }

    public async Task Do(ProductViewModel viewModel)
    {
      _context.Products.Add(new Product
      {
        Name = viewModel.Name,
        Description = viewModel.Description,
        Value = viewModel.Value
      });

      await _context.SaveChangesAsync();
    }

    public class ProductViewModel
    {
      public string Name { get; set; }
      public string Description { get; set; }
      public decimal Value { get; set; }
    }

  }  
}
