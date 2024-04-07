using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static MediationCorner.Infrastructure.DataConstants.ValidationConstants;

namespace MediationCorner.Infrastructure.Data.Models
{
        [Index(nameof(StartTime), IsUnique = true)]
    public class Appointment
    {
        [Key]
        [Comment("Appointment identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(AppointmentDescriptionMaxLength)]
        [Comment("Reason for the appointment")]
        public string ShortDescription { get; set; } = null!;

        [Required]
        [Comment("Client")]
        public ApplicationUser Client { get; set;} = null!;

        [Comment("Starting time of the appointment")]
        public DateTime StartTime { get; set; }

        [Comment("End time for the appointment")]
        public DateTime EndTime { get; set; }

    }
}
