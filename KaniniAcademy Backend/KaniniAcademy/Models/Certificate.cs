using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace KaniniAcademy.Models
{
    public partial class Certificate
    {
        [Key]
        public int Cid { get; set; }
        public string? Cname { get; set; }
        public int? Duration { get; set; }
        public string? Projects { get; set; }
        public int? VideosDuration { get; set; }
        public byte[]? Image { get; set; }
        public string? KeySkills { get; set; }
        public string? Description { get; set; }
        public string? TrainingFormat { get; set; }
        public string?CertificatePass { get; set; }
       public ICollection<CtcReg>? CtcReg { get; set; }
    }
}
