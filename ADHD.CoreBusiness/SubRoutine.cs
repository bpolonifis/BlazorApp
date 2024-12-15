using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADHD.CoreBusiness
{
    public class SubRoutine
    {
        [Required] public int RoutineId { get; set; }
        [Required] public int SubRoutineId { get; set; }
        public int? SubPreRoutineId   { get; set; }
        public int? SubAfterRoutineId { get; set; }
        [Required] public  string? SubRoutineName { get; set; }
        public string? SubRoutineLocation { get; set; }
        public string? SubRoutineItem { get; set; } = string.Empty;
        public Nullable<DateTime> SubRoutineTimeDuration  { get; set; } = null;
        public int? SubRoutineCount { get; set; }
        public string? SubRoutineDescription { get; set; }
        public string?  SubRoutineType { get; set; }
        public  Nullable<DateTime> SubRoutineSchedule { get; set; }=null;
    };
};
