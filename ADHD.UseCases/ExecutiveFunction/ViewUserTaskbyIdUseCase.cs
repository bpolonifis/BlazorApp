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
    public class ViewUserTaskbyIdUseCase : IViewUserTaskbyIdUseCase
    {
        private readonly IUserTasksRepository userTasksRepository;

        public ViewUserTaskbyIdUseCase(IUserTasksRepository userTasksRepository)
        {
            this.userTasksRepository = userTasksRepository;
        }
        public async Task<UserTask> ExecuteAsync(int taskId)
        {
            return await this.userTasksRepository.GetUserTasksByTaskIdAsync(taskId);
        }
    }
}
