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
    public class EditUserTaskUseCase : IEditUserTaskUseCase
    {
        private readonly IUserTasksRepository userTasksRepository;

        public EditUserTaskUseCase(IUserTasksRepository userTasksRepository)
        {
            this.userTasksRepository = userTasksRepository;
        }
        public async Task ExecuteAsync(UserTask userTask)
        {
            await this.userTasksRepository.UpdateUserTaskAsync(userTask);
        }
    }
}
