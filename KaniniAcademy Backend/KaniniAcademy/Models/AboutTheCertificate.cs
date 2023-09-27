using System.ComponentModel.DataAnnotations;
namespace KaniniAcademy.Models
{
    public partial class AboutTheCertificate
    {
        [Key]
        public int ImageId { get; set; }
        public byte[]? Image1 { get; set; }
        public string? shareCert { get; set; }
        public byte[]? Image2 { get; set; }
        public string? onlinecour { get; set; }
        public byte[]? Image3 { get; set; }
        public string? schedule { get; set; }
        public byte[]? Image4 { get; set; }
        public string? level { get; set; }
        public byte[]? Image5 { get; set; }
        public string? approtime { get; set; }
        public byte[]? Image6 { get; set; }
        public string? language { get; set; }
    }
}
