
namespace Jezoori.Controllers;

public class OrderDetailController : Controller
{
    private readonly IOrderDetailRepository _orderDetailRepository;

    public OrderDetailController(IOrderDetailRepository orderDetailRepository)
    {
        _orderDetailRepository = orderDetailRepository;
    }
    public IActionResult Index()
    {
        return View();
    }
}
