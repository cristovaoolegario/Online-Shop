using Shop.Database;
using Shop.Domain.Models;
using System.Threading.Tasks;

namespace Shop.Application.ProductsAdmin
{
  public class UpdateProduct
  {
    private ApplicationDbContext _context;
    public UpdateProduct(ApplicationDbContext context)
    {
      _context = context;
    }

    public async Task Do(ProductViewModel viewModel)
    {
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
