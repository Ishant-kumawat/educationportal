using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KaniniAcademy.Models
{
    public partial class Training
    {
        [Key]
        public int Tid { get; set; }
        public string? Description { get; set; }
        public byte[]? Video { get; set; }
        public byte[]? Image { get; set; }
        public string? Tname { get; set; }
        public string? Category { get; set; }
        public byte[]? Logo { get; set; }
        public int? Duration { get; set; }
        public string? Resources { get; set; }
        [ForeignKey("Creator")]
        public int? CreatorId { get; set; }
        public Creator? Creator { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Submission>? Submissions { get; set; }
        public ICollection<CtcReg>? ctcs { get; set; }

    }
}
