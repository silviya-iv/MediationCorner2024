using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediationCorner.Infrastructure.Data.Models
{
    public class Response
    {
        public int Id { get; set; }

        [Comment("Response to Inquiry")]
        [Required]
        public string InquiryResponse { get; set; } = null!;

        [Comment("Date of the response")]
        public DateTime DateOfResponse { get; set; }= DateTime.Now;

        [ForeignKey(nameof(Inquiry))]
        public int InquiryId { get; set; }

        public Inquiry Inquiry { get; set; } = null!;


    }
}
