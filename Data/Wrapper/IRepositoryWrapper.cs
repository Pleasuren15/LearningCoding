namespace LearningCoding.Data.Wrapper
{
    public interface IRepositoryWrapper
    {
        IRepositoryProgrammingLanguage _repositoryProgramming { get; }
        IRepositoryFeedback _repositoryFeedback { get; }
        IRepositoryBook _repositoryBook { get; }
    }
}
