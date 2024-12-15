using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADHD.CoreBusiness
{
    public class Routine
    {
        [Required] public int RoutineId { get; set; }
        [Required] public  string? RoutineName { get; set; }
        public string? RoutineDescription { get; set; } = string.Empty;
        public string? RoutineLocation { get; set; } = string.Empty;
        public string? RoutineItems { get; set; } = string.Empty;
        public Nullable<DateTime> RoutineTimeDuration  { get; set; } = null;
        public string? RoutineType { get; set; }
        public Nullable<DateTime> SubRoutineSchedule { get; set; } = null;
        public int? RoutineCount { get; set; }
    };
};
