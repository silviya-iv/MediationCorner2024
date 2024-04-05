using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediationCorner.Infrastructure.Data.Models
{
        public class Inquiry
    {
        [Key]
        [Comment("Inquiry identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Inquiry title")]
        public string Title { get; set; } = null!;

        [Required]
        [Comment("Inquiry description")]
        public string Description { get; set; }= null!;

        [Comment("Inquiry initiator's phone number ")]
        public string? PhoneNumber { get; set; }

        [Comment("Date of the iquiry initiation")]
        public DateTime Date { get; set; }= DateTime.Now;

        [Comment("Iquiry initiator")]
        public ApplicationUser Initiator { get; set; } = null!;

        [Comment("Answer")]
        public string? Answer { get; set; }
    }
}
