using Millionaires.DAL.Interfaces;
using Millionaires.DAL.Repositories;
using Millionaires.Models;

namespace Millionaires.DAL
{
    public class Service : IService
    {
        private readonly MillionairesContext _context;
        public Service(MillionairesContext context)
        {
            _context = context;
            Questions = new QuestionRepository(_context);
            Levels = new LevelRepository(_context);
        }
        public IQuestionRepository Questions{ get; private set; }
        public ILevelRepository Levels { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
