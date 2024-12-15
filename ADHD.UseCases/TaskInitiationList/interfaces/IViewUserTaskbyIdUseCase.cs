using ADHD.CoreBusiness;

namespace ADHD.UseCases.ExecutiveFunction.Interfaces
{
    public interface IViewUserTaskbyIdUseCase
    {
        Task<UserTask> ExecuteAsync(int taskId);
    }
}