namespace ADHD.UseCases.ExecutiveFunction.Interfaces
{
    public interface IDeleteUserTaskUseCase
    {
        Task ExecuteAsync(int TaskId);
    }
}