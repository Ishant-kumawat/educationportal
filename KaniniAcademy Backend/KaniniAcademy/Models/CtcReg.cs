using KaniniAcademy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KaniniAcademy.Models
{
    public partial class CtcReg
    {
        [Key]
        public int CtcId { get; set; }
        public int? CertificateId { get; set; }
        public int? UserId { get; set; }
        public int? CourseId { get; set; }
        [ForeignKey("CourseId")]
        public  Course? Course { get; set; }
        [ForeignKey("TrainingId")]public Training? Trainings { get; set; }
        [ForeignKey("UserId")]
        public UserDetail? UserDetail { get; set; }
        [ForeignKey("CertificateId")]
        public Certificate? Certificate { get; set; }
    }
}