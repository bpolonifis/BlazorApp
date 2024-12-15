using ADHD.CoreBusiness;

namespace ADHD.UseCases.ExecutiveFunction.Interfaces
{
    public interface IViewToDoByNameUseCase
    {
        Task<IEnumerable<ToDo>> ExecuteAsync(string name = "");
    }
}