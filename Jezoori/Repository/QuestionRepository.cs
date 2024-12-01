namespace Jezoori.Repository;

public class QuestionRepository:BaseService<Question>,IQuestionRepository
{
    private readonly ApplicationDbContext _context;
    public QuestionRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
