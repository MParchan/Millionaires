using Millionaires.DAL.Interfaces;
using Millionaires.Models;

namespace Millionaires.DAL.Repositories
{
    public class LevelRepository : GenericRepository<Level>, ILevelRepository
    {
        public LevelRepository(MillionairesContext context) : base(context)
        {
        }
    }
}
