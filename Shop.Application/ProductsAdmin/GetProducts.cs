using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Application.ProductsAdmin
{
  public class GetProducts
  {
    private ApplicationDbContext _context;

    public GetProducts(ApplicationDbContext context)
    {
      _context = context;
    }

    public IEnumerable<ProductViewModel> Do() =>
      _context.Products.
               ToList().
               Select(item => new ProductViewModel()
               {
                 Id = item.Id,
                 Name = item.Name,
                 Description = item.Description,
                 Value = item.Value
               });

    public class ProductViewModel
    {
      public int Id { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
      public decimal Value { get; set; }
    }

  }
}
