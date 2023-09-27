using KaniniAcademy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KaniniAcademy.Models
{

    public partial class Creator
    {
        [Key]
        public int CreatorId { get; set; }
        public string? CreatorName { get; set; }
        public byte[]? CreatorImage { get; set; }
        public string? Description { get; set; }
        public string? CreatorJob { get; set; }
        public int? Followers { get; set; }
        public ICollection<Blog> ?Blogs { get; set; }
        public ICollection<Course>? Courses { get; set; }
        public ICollection<FreeResource>? FreeResources { get; set; } 
        public ICollection<Training>? Training { get; set; } 
    }
}