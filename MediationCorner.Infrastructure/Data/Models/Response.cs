using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MediationCorner.Infrastructure.DataConstants.ValidationConstants;

namespace MediationCorner.Infrastructure.Data.Models
{
    public class Response
    {
        [Key]
        [Comment("Response identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(InquiryAnswerMaxLength)]
        [Comment("Response to inquiry")]
        public string InquiryResponse { get; set; } = null!;

        [Comment("Date of the response")]
        public DateTime DateOfResponse { get; set; }= DateTime.Now;

        [ForeignKey(nameof(Inquiry))]
        [Comment("Inquiry identifier")]
        public int InquiryId { get; set; }

        public Inquiry Inquiry { get; set; } = null!;


    }
}
