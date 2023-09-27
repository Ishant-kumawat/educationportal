using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace KaniniAcademy.Models
{
    public partial class UserDetail
    {
        [Key]
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public DateTime? Dob { get; set; }
        public string? Gender { get; set; }
        public long? MobileNo { get; set; }
        public ICollection<Review>? Reviews { get; set;} 
        public ICollection<Submission>? Submissions { get; set;}
        public ICollection<StatusOfLearner>? StatusOfLearner { get; set; }
        public ICollection<Point>? Points { get; set;}
        public ICollection<Note>? Notes { get; set; }
        public ICollection<CtcReg>? CtcRegs { get; set; }
    }
}