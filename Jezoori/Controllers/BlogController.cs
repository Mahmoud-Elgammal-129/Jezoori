
namespace Jezoori.Controllers;

public class BlogController : Controller
{
    private readonly IBlogRepository _blogRepository;
    public BlogController(IBlogRepository blogRepository)
    {
        _blogRepository = blogRepository;
    }
    public IActionResult Index()
    {
        return View();
    }
}
