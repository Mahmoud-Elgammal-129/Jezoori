namespace Jezoori.Repository;

public class OrderDetailRepository:BaseService<OrderDetail>,IOrderDetailRepository
{
    private readonly ApplicationDbContext _context;
    public OrderDetailRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
