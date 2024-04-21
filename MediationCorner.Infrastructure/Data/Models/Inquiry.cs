using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MediationCorner.Infrastructure.DataConstants.ValidationConstants;

namespace MediationCorner.Infrastructure.Data.Models
{
        public class Inquiry
    {
        [Key]
        [Comment("Inquiry identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(InquiryTitleMaxLength)]
        [Comment("Inquiry title")]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(InquiryDescriptionMaxLength)]
        [Comment("Inquiry description")]
        public string Description { get; set; }= null!;

        [StringLength(InitiatorPhoneMaxLength)]
        [Comment("Inquiry initiator's phone number ")]
        public string? PhoneNumber { get; set; }

        [Comment("Date of the iquiry initiation")]
        public DateTime Date { get; set; }= DateTime.Now;


        [Required]
        [ForeignKey(nameof(Initiator))]
        [Comment("Iquiry initiator")]
        public string InitiatorId { get; set; } = null!;

       
        public ApplicationUser Initiator { get; set; } = null!;

        
        [Comment("Answer")]
        public Response? Response { get; set; }
    }
}
