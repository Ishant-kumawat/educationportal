using KaniniAcademy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KaniniAcademy.Models
{
    public partial class CourseResource
    {
        [Key]
        public int CourseResourceID { get; set; }
        public byte[]? Video { get; set; } 
        public byte[]? Thumbnail { get; set; } 
        public string? Description { get; set; } 
        public string? Review { get; set; } 
        public string? Resources { get; set; }
        public int? CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course? Course { get; set; }
    }
}
