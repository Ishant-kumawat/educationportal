using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KaniniAcademy.Models
{
    public partial class StatusOfLearner
    {
        [Key]
        public int StatusId { get; set; }
        public int? CourseCompletion { get; set; }
        public int? UserID { get; set; }
        [ForeignKey("UserID")]
        public UserDetail? UserDetail { get; set; }
        public int? CourseID { get; set; }
        [ForeignKey("CourseID")]
        public Course? Course { get; set; }
    }
}