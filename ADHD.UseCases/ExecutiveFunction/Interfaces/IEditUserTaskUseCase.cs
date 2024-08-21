using ADHD.CoreBusiness;

namespace ADHD.UseCases.ExecutiveFunction.Interfaces
{
    public interface IEditUserTaskUseCase
    {
        Task ExecuteAsync(UserTask userTask);
    }
}