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
    class SubRoutineRepository : ISubRoutineRepository
    {
        private List<SubRoutine> _subRoutineList;

        public SubRoutineRepository()
        {
            _subRoutineList = new List<SubRoutine>();
            {
                new SubRoutine
                {
                    RoutineId = 1,
                    SubRoutineId = 3,
                    SubPreRoutineId = null,
                    SubAfterRoutineId = null,
                    SubRoutineName = "Test",                    
                    SubRoutineLocation = "Couch",
                    SubRoutineItem = "Laptop",
                    SubRoutineTimeDuration = null,
                    SubRoutineCount = 0,
                    SubRoutineDescription = "ToDoDescription",
                    SubRoutineType = "Work",
                    SubRoutineSchedule = null                    
                };
            };
        }

        public Task AddSubRoutineAsync(SubRoutine subRoutine)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSubRoutineByIdAsync(int subRoutineId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SubRoutine>> GetSubRoutineByDescriptionAsync(string description)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SubRoutine>> GetSubRoutineByNameAsync(string subRoutineName)
        {

            if (string.IsNullOrEmpty(subRoutineName)) return await Task.FromResult(_subRoutineList);

            return _subRoutineList.Where(x => x.SubRoutineName.Contains(subRoutineName, StringComparison.OrdinalIgnoreCase));           
        }

        public Task<SubRoutine> GetSubRoutineBySubRoutineIdAsync(int subRoutineId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSubRoutineAsync(SubRoutine subRoutine)
        {
            throw new NotImplementedException();
        }
    }
}
