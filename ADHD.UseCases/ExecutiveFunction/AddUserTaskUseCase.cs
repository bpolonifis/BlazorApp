using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADHD.CoreBusiness;
using ADHD.UseCases.ExecutiveFunction.Interfaces;
using ADHD.UseCases.PluginInterfaces;

namespace ADHD.UseCases.ExecutiveFunction
{
    public class AddUserTaskUseCase : IAddUserTaskUseCase
    {
        private readonly IUserTasksRepository userTasksRepository;

        public AddUserTaskUseCase(IUserTasksRepository userTasksRepository)
        {
            this.userTasksRepository = userTasksRepository;
        }
        public async Task ExecuteAsync(UserTask userTask)
        {
            await this.userTasksRepository.AddUserTaskAsync(userTask);
        }
    }
}
