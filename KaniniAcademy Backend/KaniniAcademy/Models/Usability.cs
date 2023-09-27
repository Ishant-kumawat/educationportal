using System.ComponentModel.DataAnnotations;
namespace KaniniAcademy.Models
{
    public class Usability
    {
        [Key]
        public int id { get; set; }
        public string? Description { get; set; }
    }
}
