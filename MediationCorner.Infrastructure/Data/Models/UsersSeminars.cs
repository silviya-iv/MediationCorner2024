using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediationCorner.Infrastructure.Data.Models
{
    public class UsersSeminars
    {
        [Required]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public IdentityUser User { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Seminar))]
        public int SeminarId { get; set; }
        public Seminar Seminar { get; set; } = null!;

    }
}
