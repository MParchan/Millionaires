namespace Millionaires.DAL.Interfaces
{
    public interface IService : IDisposable
    {
        IQuestionRepository Questions { get; }
        ILevelRepository Levels { get; }
        int Complete();
    }
}
