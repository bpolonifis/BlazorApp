using System.ComponentModel.DataAnnotations;

namespace ADHD.CoreBusiness
{
    public class UserTask
    {
        [Required]        public int TaskId { get; set; }
        [Required] [StringLength(150)]       public string TaskDescription { get; set; } = string.Empty;
        public string? TaskLocation { get; set; }
        public DateTime? TaskTimePrediction { get; set; }
        public DateTime?  TaskTimeInitiated { get; set; }
        public DateTime? TaskTimeFinished { get; set; }
        public bool TaskStatus { get; set; } = false;
        [StringLength(75)] public string TaskName { get; set; } = string.Empty;
        public string? TaskType { get; set; }
        public int? TaskCount { get; set; }
        public int? PreTaskId { get; set; }
        public int? AfterTaskId { get; set; }
    }
}