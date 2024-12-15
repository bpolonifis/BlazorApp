using ADHD.CoreBusiness;

namespace ADHD.Plugins.InMemory
{
    public interface ISubRoutineRepository
    {      
    Task AddSubRoutineAsync(SubRoutine subRoutine);
    Task DeleteSubRoutineByIdAsync(int subRoutineId);
    Task<IEnumerable<SubRoutine>> GetSubRoutineByDescriptionAsync(string description);
    Task<SubRoutine> GetSubRoutineBySubRoutineIdAsync(int subRoutineId);
    Task UpdateSubRoutineAsync(SubRoutine subRoutine);        
    }
}