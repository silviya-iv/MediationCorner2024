using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey(nameof(FirstParty))]
        [Comment("Initiator of the mediation request")]
        public string FirstPartyId { get; set; } = null!;
           
        
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
