using ADHD.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADHD.UseCases.PluginInterfaces
{
    public interface IToDoRepository
    {
        Task<IEnumerable<ToDo>> GetToDoByNameAsync(string name);
        Task AddToDoAsync(ToDo toDo);
        Task DeleteToDoByIdAsync(int toDoId);
        Task<IEnumerable<ToDo>> GetToDoByDescriptionAsync(string description);
        Task<ToDo> GetUserToDoByToDoIdAsync(int ToDoId);
        Task UpdateToDoAsync(ToDo toDo);
    }
}
