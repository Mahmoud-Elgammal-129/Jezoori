
namespace Jezoori.Controllers;

public class SurveyController : Controller
{
    private readonly ISurveyRepository _surveyRepository;

    public SurveyController(ISurveyRepository surveyRepository)
    {
        _surveyRepository = surveyRepository;
    }
    public IActionResult Index()
    {
        return View();
    }
}
