using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Products;
using Shop.Application.ProductsAdmin;
using Shop.Database;
using System.Collections.Generic;
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
    public CreateProduct.ProductViewModel Product { get; set; }

    public IEnumerable<GetProducts.ProductViewModel> Products { get; set; }

    public void OnGet()
    {
      Products = new GetProducts(_context).Do();
    }

    public async Task<IActionResult> OnPost()
    {
      await new CreateProduct(_context).
        Do(Product);

      return RedirectToPage("Index");
    }
  }
}
