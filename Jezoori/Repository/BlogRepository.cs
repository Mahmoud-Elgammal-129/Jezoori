namespace Jezoori.Repository;

public class BlogRepository:BaseService<Blog>,IBlogRepository
{
    private readonly ApplicationDbContext _context;
    public BlogRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
