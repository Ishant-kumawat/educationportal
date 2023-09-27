using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KaniniAcademy.Models
{
    public partial class FreeResource
    {
        [Key]
        public int FreeRid { get; set; }
        public string? Title { get; set; }
        public string? Category { get; set; }
        public int? Downloads { get; set; }
        public string? Description { get; set; }
        public byte[]? Thumbnail { get; set; }
        public string? Book { get; set; }
        public string? Template { get; set; }
        public byte[]? Video { get; set; }
        [ForeignKey("Creator")]
        public int? CreatorId { get;set; }
        public string? mainfeature { get; set; }

        
    }
}