
namespace Jezoori.Controllers;

public class ProductCategoryController : Controller
{
    private readonly IProductCategoryRepository _productCategoryRepository;

    public ProductCategoryController(IProductCategoryRepository productCategoryRepository)
    {
       _productCategoryRepository = productCategoryRepository;
    }
    public IActionResult Index()
    {
        return View();
    }
}
