using ADHD.CoreBusiness;
using ADHD.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADHD.Plugins.InMemory
{
    class ToDoRepository : IToDoRepository
    {
        private List<ToDo> _toDoList;

        public ToDoRepository()
        {
            _toDoList = new List<ToDo>();
            {
                new ToDo
                {
                    ToDoListId = 1,
                    ToDoId = 3,
                    PreToDoId = null,
                    AfterToDoId = null,
                    ToDoName = "Test",
                    ToDoType = "Work",
                    ToDoLocation = "Couch",
                    ToDoDescription = "ToDoDescription",
                    ToDoItem = "Laptop",
                    ToDoStatus = false,
                    TodoDuration = null,
                    ToDoCount = 0,
                    ToDoTaskId = null,
                    ToDoRoutineId = 1,
                };
            };
        }

        public Task AddToDoAsync(ToDo toDo)
        {
            throw new NotImplementedException();
        }

        public Task DeleteToDoByIdAsync(int toDoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ToDo>> GetToDoByDescriptionAsync(string description)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ToDo>> GetToDoByNameAsync(string toDoName)
        {

            if (string.IsNullOrEmpty(toDoName)) return await Task.FromResult(_toDoList);

            return _toDoList.Where(x => x.ToDoName.Contains(toDoName, StringComparison.OrdinalIgnoreCase));           
        }

        public Task<ToDo> GetUserToDoByToDoIdAsync(int ToDoId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateToDoAsync(ToDo toDo)
        {
            throw new NotImplementedException();
        }
    }
}
