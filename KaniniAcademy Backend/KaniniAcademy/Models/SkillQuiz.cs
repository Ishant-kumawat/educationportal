using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using KaniniAcademy.Models;
namespace KaniniAcademy.Models
{

    public partial class SkillQuiz
    {
        [Key]
        public int QuizId { get; set; }
        public string? Subject { get; set; }
        public string? Topic { get; set; }
        public byte[]? Thumbnail { get; set; }
        public  ICollection<Qa>? Qas { get; set; } 
        public ICollection<Point>? Points { get; set; }
    }
}