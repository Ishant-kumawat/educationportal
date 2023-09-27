using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace KaniniAcademy.Models
{
    public partial class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string? Topic { get; set; }
        public DateTime? DateOfUpload { get; set; } = DateTime.UtcNow;
        public byte[]? Image { get; set; }
        public string? Description { get; set; }
        public string? BlogCategory { get; set; }
        [ForeignKey("Creator")]
        public int? CreatorId { get; set; }  

        
    }
}
