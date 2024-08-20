using ADHD.UseCases.PluginInterfaces;
using UserTask = ADHD.CoreBusiness.UserTask;

namespace ADHD.Plugins.InMemory
{
    public class UserTasksRepository : IUserTasksRepository

    {
        private List<UserTask> _userTasks;

        public UserTasksRepository()
        {
            _userTasks = new List<UserTask>()
            {
                //new UserTask
                //{
                //    TaskId = 1,TaskDescription = "Test",TaskLocation = "Test",
                //    TaskTimePrediction = new DateTime(0, 0, 0), TaskTimeInitiated = new DateTime (0, 0, 0), TaskTimeFinished = new DateTime (0, 0, 0),
                //    TaskStatus = false,TaskName = "", TaskCount = 0, PreTaskId = 0, AfterTaskId = 0
                //},
                //new UserTask
                //{
                //    TaskId = 2,TaskDescription = "TaskBreakDown",TaskLocation = "Home",
                //    TaskTimePrediction = new DateTime(0, 0, 0), TaskTimeInitiated = new DateTime(0, 0, 0), TaskTimeFinished = null,
                //    TaskStatus = false,TaskName = "", TaskCount = 0, PreTaskId = 0, AfterTaskId = 0
                //},
                new UserTask
                {
                    TaskId = 3,TaskDescription = "TaskInitiation",TaskLocation = "Home",
                    TaskTimePrediction = null, TaskTimeInitiated = null, TaskTimeFinished = null,
                    TaskStatus = false,TaskName = "", TaskCount = 0, PreTaskId = 0, AfterTaskId = 0
                }
            };

        }

        public Task AddUserTaskAsync(UserTask userTask)
        {
            //NOT NEEDED FOR OUR CASE
            //if (_userTasks.Any(x => x.TaskName.Equals(userTask.TaskName, StringComparison.OrdinalIgnoreCase)))
            //{
            //    return Task.CompletedTask;
            //}

            var maxId = _userTasks.Max(x => x.TaskId);
            userTask.TaskId = maxId +1 ;

            _userTasks.Add(userTask);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<UserTask>>GetUserTasksByDescriptionAsync(string description)
        {
            if (string.IsNullOrEmpty(description)) return await Task.FromResult(_userTasks);

            return _userTasks.Where(x => x.TaskDescription.Contains(description,StringComparison.OrdinalIgnoreCase));

        }

        public async Task<UserTask> GetUserTasksByTaskIdAsync(int taskId)
        {
            return await Task.FromResult(_userTasks.First(x => x.TaskId == taskId));
        }

        public Task UpdateUserTaskAsync(UserTask userTask)
        {
            //NOT NEEDED FOR OUR CASE ( uniqueness of Name)    

            //if (_userTasks.Any(x => x.TaskId != userTask.TaskId &&
            //    x.TaskName.Equals(userTask.TaskName, StringComparison.OrdinalIgnoreCase)))
            //{
            //    return Task.CompletedTask;
            //}

            //add automapper here
            var taskToUpdate = _userTasks.FirstOrDefault(x => x.TaskId == userTask.TaskId);
            if (taskToUpdate is not null)
            {
                taskToUpdate.TaskDescription = userTask.TaskDescription;
                taskToUpdate.TaskLocation = userTask.TaskLocation;
                taskToUpdate.TaskName = userTask.TaskName;
                taskToUpdate.TaskStatus = userTask.TaskStatus;
                taskToUpdate.TaskTimeInitiated = userTask.TaskTimeInitiated;
                taskToUpdate.TaskTimePrediction = userTask.TaskTimePrediction;
                taskToUpdate.TaskCount = userTask.TaskCount;
                taskToUpdate.TaskType = userTask.TaskType;
            }
            return Task.CompletedTask;
        }
    }
}
