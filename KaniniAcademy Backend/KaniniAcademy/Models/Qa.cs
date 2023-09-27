using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KaniniAcademy.Models;
namespace KaniniAcademy.Models
{
    public partial class Qa
    {
        [Key]
        public int Qid { get; set; }
        public string? Question { get; set; }
        public string? Hint { get; set; }
        public string? Op1 { get; set; }
        public string? Op2 { get; set; }
        public string? Op3 { get; set; }
        public string? Op4 { get; set; }
        public string? Ans { get; set; }
        public int? SkillQuizId { get; set; }
        [ForeignKey("SkillQuizId")]
        public SkillQuiz ?SkillQuiz { get; set; }

    }
}