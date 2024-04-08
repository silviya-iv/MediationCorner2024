using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MediationCorner.Infrastructure.DataConstants.ValidationConstants;

namespace MediationCorner.Infrastructure.Data.Models
{
    public class Seminar
    {
        public Seminar() 
        {
            UsersSeminars=new HashSet<UserSeminar>();
        }

        [Key]
        [Comment("Seminar identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(SeminarTitleMaxLength)]
        [Comment("Seminar title")]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(SeminarDescriptionMaxLength)]
        [Comment("Seminar description")]
        public string Description { get; set; }= null!;

        [Comment("Date and time of the seminar")]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(SeminarLocationMaxLength)]
        [Comment("Location where the seminar will take place")]
        public string Location { get; set; } = null!;

        [Comment("Price for attending the seminar")]
        [Column(TypeName ="decimal(6,2)")]
        public decimal Price { get; set; }

        [Comment("Deadline for sign up for the seminar")]
        public DateTime RegistrationDeadline { get; set; }

        [Required]
        [ForeignKey(nameof(Lecturer))]
        [Comment("Lecturer of the seminar")]
        public int LecturerId { get; set; }

        public Lecturer Lecturer { get; set; } = null!;

        public ICollection<UserSeminar> UsersSeminars { get; set; }

    }
}
