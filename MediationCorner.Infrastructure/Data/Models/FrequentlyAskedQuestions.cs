using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediationCorner.Infrastructure.Data.Models
{
    public class FrequentlyAskedQuestions
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Comment("Question")]
        public string Question { get; set; } = null!;

        [Required]
        [Comment("Response to question")]
        public string Answer { get; set; } = null!;
    }
}
