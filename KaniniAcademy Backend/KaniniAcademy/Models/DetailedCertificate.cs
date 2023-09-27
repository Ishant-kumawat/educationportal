using System.ComponentModel.DataAnnotations;
namespace KaniniAcademy.Models
{
    public partial class DetailedCertificate
    {
        [Key]
        public int detailId { get; set; }
        public string? AboutAns1 { get; set; }
        public string? AboutAns2 { get; set; }
        public string? AboutAns3 { get; set; }
        public string? AboutAns4 { get; set; }
        public string? AboutAns5 { get; set; }
        public string? AboutAns6 { get; set; }
        public string? AboutAns7 { get; set; }
        public string? AboutAns8 { get; set; }
        public string? AboutAns9 { get; set; }
        public string? AboutAns10 { get; set; }
        public string? AboutAns11 { get; set; }
        public string? Work1 { get; set; }
        public string? WorkAns1 { get; set; }
        public string? Work2 { get; set; }
        public string? WorkAns2 { get; set; }
        public string? Work3 { get; set; }
        public string? WorkAns3 { get; set; }
        public string? FaqQues1 { get; set; }
        public string? FaqAns1 { get; set; }
        public string? FaqQues2 { get; set; }
        public string? FaqAns2 { get; set; }
        public string? FaqQues3 { get; set; }
        public string? FaqAns3 { get; set; }
        public string? FaqQues4 { get; set; }
        public string? FaqAns4 { get; set; }
        public string? FaqQues5 { get; set; }
        public string? FaqAns5 { get; set; }
    }
}
