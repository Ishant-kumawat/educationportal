using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KaniniAcademy.Models
{
    public partial class Submission
    {
        [Key]
        public int SubId { get; set; }
        public string? Work { get; set; }
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public UserDetail? UserDetail { get; set; }
        public int? TrainingId { get; set; }
        [ForeignKey("TrainingId")]
        public Training? Training { get; set; }

    }
}