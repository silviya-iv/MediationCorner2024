using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace MediationCorner.Infrastructure.Data.Models
{
    public class UsersSeminars
    {
        [Required]
        [ForeignKey(nameof(User))]
        [Comment("User identifier")]
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Seminar))]
        [Comment("Seminar identifier")]
        public int SeminarId { get; set; }

        public Seminar Seminar { get; set; } = null!;

    }
}
