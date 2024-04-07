using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static MediationCorner.Infrastructure.DataConstants.ValidationConstants;

namespace MediationCorner.Infrastructure.Data.Models
{
    public class Lecturer
    {
        [Key]
        [Comment("Lecturer identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(LecturerNameMaxLength)]
        [Comment("Lecturer's name")]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(LecturerSummaryMaxLength)]
        [Comment("Lecturer's summary")]
        public string Summary { get; set;} = null!;

        [Comment("Lecturer photo")]
        public byte[]? Photo { get; set; }

    }
}
