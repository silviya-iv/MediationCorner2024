using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MediationCorner.Infrastructure.DataConstants.ValidationConstants;

namespace MediationCorner.Infrastructure.Data.Models
{
    public class ProgressStatus
    {
        [Key]
        [Comment("Current status identifier")]
        public int Id { get; set; }

        [Comment("Date of the status")]
        public DateTime Date { get; set; }= DateTime.Now;

        [Required]
        [StringLength(MediationRequestStatusMaxLengt)]
        [Comment("Current status of the mediation request")]
        public string CurrrentStatus { get; set; } = null!;

        [Required]
        [StringLength(MediationRequestStatusDescriptoionMaxLengt)]
        [Comment("Current status description")]
        public string Description { get; set; }=null!;

        [Required]
        [ForeignKey(nameof(MediationRequest))]
        public int MediationRequestId { get; set; }

        public MediationRequest MediationRequest { get; set; } = null!;
      
    }
}
