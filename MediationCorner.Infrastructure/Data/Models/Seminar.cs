using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MediationCorner.Infrastructure.Data.Models
{
    public class Seminar
    {
        public Seminar() 
        {
            Attendees=new HashSet<IdentityUser>();
        }

        [Key]
        public int Id { get; set; }

        [Required] 
        public string Title { get; set; } = null!;

        [Required]
        public string Description { get; set; }= null!;

        [Comment("Date and time of the Seminar")]
        public DateTime Date { get; set; }

        [Required]
        [Comment("Location where the seminar will take place")]

        public string Location { get; set; } = null!;

        [Comment("Price for attending the seminar")]
        public decimal Price { get; set; }

        [Comment("Deadline for sign up for the seminar")]
        public DateTime RegistrationDeadline { get; set; }

        [Required]
        [ForeignKey(nameof(Lecturer))]
        [Comment("Lecturer of the seminar")]
        public int LecturerId { get; set; }

        public Lecturer Lecturer { get; set; } = null!;

        public ICollection<IdentityUser> Attendees { get; set; }

    }
}
