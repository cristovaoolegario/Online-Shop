using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Application.GetProducts
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
                 Name = item.Name,
                 Description = item.Description,
                 Value = $"R$ {item.Value.ToString("N2")}"
               });
  }

  public class ProductViewModel
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public string Value { get; set; }
  }
}
