using ADHD.CoreBusiness;

namespace ADHD.UseCases.ExecutiveFunction.Interfaces
{
    public interface IAddUserTaskUseCase
    {
        Task ExecuteAsync(UserTask userTask);
    }
}