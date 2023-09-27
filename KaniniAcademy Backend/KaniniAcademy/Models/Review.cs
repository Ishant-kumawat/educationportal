using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KaniniAcademy.Models
{

    public partial class Review
    {
        [Key]
        public int RId { get; set; }
        public string? Rname { get; set; }
        public int? Rating { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string? Description { get; set; }
        [ForeignKey("Training")]
        public  Training? TraningId { get; set; }
        [ForeignKey("UserDetail")]
        public UserDetail? UserId { get; set; }
        [ForeignKey("Course")]
        public int? CourseId { get; set; }
    }
}