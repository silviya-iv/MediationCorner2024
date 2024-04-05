using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace MediationCorner.Infrastructure.Data.Models
{
    public class FrequentlyAskedQuestions
    {
        [Key]
        [Comment("Question identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Question")]
        public string Question { get; set; } = null!;

        [Required]
        [Comment("Response to question")]
        public string Answer { get; set; } = null!;
    }
}
