
namespace Jezoori.Controllers;

public class RecipeController : Controller
{
    private readonly IRecipeRepository _recipeRepository;

    public RecipeController(IRecipeRepository recipeRepository)
    {
        _recipeRepository = recipeRepository;
    }
    public IActionResult Index()
    {
        return View();
    }
}
