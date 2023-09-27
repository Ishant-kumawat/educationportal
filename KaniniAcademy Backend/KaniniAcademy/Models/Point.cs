using KaniniAcademy.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
public class Point
{
    [Key]
    public int PointId { get; set; }
    public int? Points { get; set; }
    public DateTime? Date { get; set; }
    public int? UserId { get; set; }
    public int? SkillQuizId { get; set; } 
    [ForeignKey("UserId")]
    public  UserDetail? UserDetail { get; set; } 
    [ForeignKey("SkillQuizId")]
    public  SkillQuiz? SkillQuiz { get; set; } 
}
