using ADHD.CoreBusiness;
using ADHD.UseCases.ExecutiveFunction.Interfaces;
using ADHD.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADHD.UseCases.ExecutiveFunction
{
    public class ViewUserTasksByDescriptionUseCase : IViewUserTasksByDescriptionUseCase
    {
        private readonly IUserTasksRepository tasksRepository;

        public ViewUserTasksByDescriptionUseCase(IUserTasksRepository userTasksRepository)
        {
            this.tasksRepository = userTasksRepository;
        }
        public async Task<IEnumerable<UserTask>> ExecuteAsync(string description = "")
        {
            return await tasksRepository.GetUserTasksByDescriptionAsync(description);
        }

    }
}
