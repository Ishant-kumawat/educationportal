using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KaniniAcademy.Models
{
    public partial class Note
    {
        [Key]
        public int NotesId { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public UserDetail? UserDetail { get; set; }
    }
}