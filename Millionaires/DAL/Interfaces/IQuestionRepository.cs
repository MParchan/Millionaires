using Millionaires.Models;

namespace Millionaires.DAL.Interfaces
{
    public interface IQuestionRepository : IGenericRepository<Question>
    {
        Question GetRandom(IEnumerable<Question> questions);
    }
}
