using ADHD.UseCases.ExecutiveFunction.Interfaces;
using ADHD.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADHD.UseCases.ExecutiveFunction
{
    public class DeleteUserTaskUseCase : IDeleteUserTaskUseCase
    {
        private readonly IUserTasksRepository userTasksRepository;

        public DeleteUserTaskUseCase(IUserTasksRepository userTasksRepository)
        {
            this.userTasksRepository = userTasksRepository;
        }

        public async Task ExecuteAsync(int TaskId)
        {
            await this.userTasksRepository.DeleteUserTaskByIdAsync(TaskId);
        }
    }
}
