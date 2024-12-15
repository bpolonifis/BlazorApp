using ADHD.CoreBusiness;

namespace ADHD.Plugins.InMemory
{
    public interface IRoutineRepository
    {
        Task AddRoutineAsync(Routine routine);
        Task DeleteRoutineByIdAsync(int routineId);
        Task<IEnumerable<Routine>> GetRoutineByDescriptionAsync(string description);
        Task<Routine> GetRoutinesByRoutineIdAsync(int routineId);
        Task UpdateRoutineAsync(Routine routine);
        
    }
}