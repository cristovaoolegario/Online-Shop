using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Products;
using Shop.Database;
using System.Threading.Tasks;
using static Shop.Application.Products.CreateProduct;

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

    public void OnGet()
    {

    }

    public async Task<IActionResult> OnPost()
    {
      await new CreateProduct(_context).
        Do(Product);

      return RedirectToPage("Index");
    }
  }
}
