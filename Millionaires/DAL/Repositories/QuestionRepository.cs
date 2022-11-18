using Millionaires.DAL.Interfaces;
using Millionaires.Models;

namespace Millionaires.DAL.Repositories
{
    public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(MillionairesContext context) : base(context)
        {
        }

        public Question GetRandom(IEnumerable<Question> questions)
        {
            return questions.OrderBy(q => Guid.NewGuid()).First();
        }
    }
}
