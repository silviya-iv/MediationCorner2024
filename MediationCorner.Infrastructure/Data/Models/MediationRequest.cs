using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static MediationCorner.Infrastructure.DataConstants.ValidationConstants;

namespace MediationCorner.Infrastructure.Data.Models
{

    public class MediationRequest
    {
        public MediationRequest()
        {
            ProgressStatuses = new List<ProgressStatus>();
        }

        [Key]
        [Comment("Request identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Initiator of the mediation request")]
        public ApplicationUser FirstParty { get; set; } = null!;

        [Required]
        [StringLength(InitiatorPhoneMaxLength)]
        [Comment("Initiator's phone number")]
        public string firstPartyPhoneNumber { get; set; } = null!;

        [Required]
        [StringLength(SecondPartyNameMaxLength)]
        [Comment ("Second party name")]
        public string SecondPartyName { get; set; } = null!;

        [Required]
        [StringLength(MediationRequestDescriptionMaxLength)]
        [Comment("Description of the mediation request")]
        public string ShortDescription { get; set; } = null!;

        ICollection<ProgressStatus> ProgressStatuses { get; set; }
        
    }
}
