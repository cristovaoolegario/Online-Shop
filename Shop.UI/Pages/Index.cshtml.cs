using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Products;
using Shop.Database;
using System.Threading.Tasks;

namespace Shop.UI.Pages
{
  public class IndexModel : PageModel
  {
    private ApplicationDbContext _context;

    public IndexModel(ApplicationDbContext dbContext)
    {
      _context = dbContext;
    }

    [BindProperty]
    public ProductViewModel Product { get; set; }

    public class ProductViewModel
    {
      public string Name { get; set; }
      public string Description { get; set; }
      public decimal Value { get; set; }
    }

    public void OnGet()
    {

    }

    public async Task<IActionResult> OnPost()
    {
      await new CreateProduct(_context).
        Do(Product.Name, Product.Description, Product.Value);

      return RedirectToPage("Index");
    }
  }
}
