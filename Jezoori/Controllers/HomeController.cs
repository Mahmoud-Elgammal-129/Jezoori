
using Jezoori.Repository.ServicesMail;

namespace Jezoori.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly EmailService _emailService;


    public HomeController(ILogger<HomeController> logger , EmailService emailService)
    {
        _logger = logger;
        _emailService = emailService;
    }


    public IActionResult SendEmail()
    {
        return View();
    }

    // POST: Home/SendEmail
    [HttpPost]
    public async Task<IActionResult> SendEmail(string toEmail, string subject, string body)
    {
        // Send email using the EmailService
        try
        {
            await _emailService.SendEmailAsync(toEmail, subject, body);
            ViewBag.Message = "Email sent successfully!";
        }
        catch (Exception ex)
        {
            ViewBag.Message = $"Failed to send email. Error: {ex.Message}";
        }

        return View();
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
