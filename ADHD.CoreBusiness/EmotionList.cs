using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADHD.CoreBusiness
{
    public class EmotionList
    {
        [Required] public int EmotionId { get; set; }
        [Required] public  DateTime Date { get; set; } = DateTime.Now;
        public string? EmotionName { get; set; } = string.Empty;
        public string? EmotionAction { get; set; } = string.Empty;
        public string? EmotionInformation { get; set; } = string.Empty;
        public string? EmotionCommunication { get; set; } = string.Empty;
        public string? EmotionRecognizion { get; set; } = string.Empty;
        public string? EmotionType { get; set; } = string.Empty;
        public bool EmotionStatus { get; set; } = false;
        [StringLength(150)] public string? EmotionDescription { get; set; } = string.Empty;
        [StringLength(50)]  public string? EmotionTag { get; set; } = string.Empty;
        public int? EmotionTagCount { get; set; }
    };
};
