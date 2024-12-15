using ADHD.CoreBusiness;
using ADHD.UseCases.ExecutiveFunction;
using ADHD.UseCases.ExecutiveFunction.Interfaces;
using ADHD.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADHD.UseCases.ToDoList
{
    public class ViewToDoByNameUseCase : IViewToDoByNameUseCase
    {
        private readonly IToDoRepository toDoRepository;

        public ViewToDoByNameUseCase(IToDoRepository toDoRepository)
        {
            this.toDoRepository = toDoRepository;
        }
        public async Task<IEnumerable<ToDo>> ExecuteAsync(string name = "")
        {
            return await toDoRepository.GetToDoByNameAsync(name);
        }
    }
}
