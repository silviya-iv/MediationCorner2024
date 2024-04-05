using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace MediationCorner.Infrastructure.Data.Models
{
    public class Lecturer
    {
        [Key]
        [Comment("Lecturer identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Lecturer's name")]
        public string Name { get; set; } = null!;

        [Required]
        [Comment("Lecturer's summary")]
        public string Summary { get; set;} = null!;

        [Comment("Lecturer photo")]
        public byte[]? Photo { get; set; }

    }
}
