using ADHD.CoreBusiness;

namespace ADHD.UseCases.ExecutiveFunction.Interfaces
{
    public interface IViewUserTasksByDescriptionUseCase
    {
        Task<IEnumerable<UserTask>> ExecuteAsync(string description = "");
    }
}