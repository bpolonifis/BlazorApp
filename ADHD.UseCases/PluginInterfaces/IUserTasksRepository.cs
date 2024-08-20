using ADHD.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADHD.UseCases.PluginInterfaces
{
    public interface IUserTasksRepository
    {
        Task AddUserTaskAsync(UserTask userTask);
        Task<IEnumerable<UserTask>> GetUserTasksByDescriptionAsync(string description);
    }
}
