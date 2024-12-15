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
    class RoutineRepository : IRoutineRepository
    {
        private List<Routine> _routine;

        public RoutineRepository()
        {
            _routine = new List<Routine>();
            {
                new Routine
                {
                    RoutineId = 1,
                    RoutineName = "Test",
                    RoutineDescription = "RoutineDescription",
                    RoutineLocation = "House",
                    RoutineItems = "Laptop",
                    RoutineTimeDuration = null,
                    RoutineType = "Work",
                    SubRoutineSchedule = null,
                    RoutineCount = 1,
                };
            };
        }

        public Task AddRoutineAsync(Routine routine)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRoutineByIdAsync(int routineId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Routine>> GetRoutineByDescriptionAsync(string description)
        {
            throw new NotImplementedException();
        }

        public Task<Routine> GetRoutinesByRoutineIdAsync(int routineId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Routine>> GetRoutineByNameAsync(string routineName)
        {

            if (string.IsNullOrEmpty(routineName)) return await Task.FromResult(_routine);

            return _routine.Where(x => x.RoutineName.Contains(routineName, StringComparison.OrdinalIgnoreCase));           
        }

        public Task UpdateRoutineAsync(Routine routine)
        {
            throw new NotImplementedException();
        }
    }
}
