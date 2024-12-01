namespace Jezoori.Repository;

public class OrderRepository : BaseService<Order>, IOrderRepository
{
    private readonly ApplicationDbContext _context;
    public OrderRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
