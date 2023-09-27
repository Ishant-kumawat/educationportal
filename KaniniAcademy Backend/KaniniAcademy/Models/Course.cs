using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KaniniAcademy.Models { 

    public partial class Course
    {
         [Key]
         public int CourseId { get; set; }
        public string? CourseName { get; set; }  
        public string? CourseProvider { get; set; } 
        public byte[]? Image { get; set; } 
        public int? Rating { get; set; } 
        public int? CreatorId { get; set; }
        [ForeignKey("CreatorId")]
        public Creator? Creator { get; set; }
        public ICollection<StatusOfLearner>? StatusOfLearners { get; set; }
        public ICollection<CourseResource>? CourseResources { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<CtcReg>? Ctcs { get; set; }
        [NotMapped]
        public IFormFile? File { get; set; }
    }

    
}
