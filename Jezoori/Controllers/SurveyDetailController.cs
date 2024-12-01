
namespace Jezoori.Controllers;

public class SurveyDetailController : Controller
{
    private readonly ISurveyDetailRepository _surveyDetailRepository;

    public SurveyDetailController(ISurveyDetailRepository surveyDetailRepository)
    {
        _surveyDetailRepository = surveyDetailRepository;
    }
    public IActionResult Index()
    {
        return View();
    }
}
