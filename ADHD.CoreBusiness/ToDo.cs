using System.ComponentModel.DataAnnotations;

namespace ADHD.CoreBusiness
{
    public class ToDo
    {
        [Required] public int ToDoListId { get; set; }
        [Required] public int ToDoId { get; set; }
        public int? PreToDoId { get; set; }
        public int? AfterToDoId { get; set; }
        [Required][StringLength(75)] public string ToDoName { get; set; } = string.Empty;
        public string? ToDoType { get; set; }
        public string? ToDoLocation { get; set; }
        [StringLength(150)] public string ToDoDescription { get; set; } = string.Empty;
        public string? ToDoItem { get; set; } = string.Empty;
        public bool ToDoStatus { get; set; } = false;
        public Nullable<DateTime> TodoDuration { get; set; } = null;
        public int? ToDoCount { get; set; }
        [Required] public int? ToDoTaskId { get; set; }
        [Required] public int? ToDoRoutineId { get; set; }

    };
}
