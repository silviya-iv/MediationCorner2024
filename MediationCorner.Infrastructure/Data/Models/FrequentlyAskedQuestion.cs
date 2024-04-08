using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static MediationCorner.Infrastructure.DataConstants.ValidationConstants;

namespace MediationCorner.Infrastructure.Data.Models
{
    public class FrequentlyAskedQuestion
    {
        [Key]
        [Comment("Question identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(FAQMaxLength)]
        [Comment("Question")]
        public string Question { get; set; } = null!;

        [Required]
        [StringLength(FAQResponseMaxLength)]
        [Comment("Response to question")]
        public string Answer { get; set; } = null!;
    }
}
