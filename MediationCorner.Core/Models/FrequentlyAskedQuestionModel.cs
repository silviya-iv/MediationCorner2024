using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MediationCorner.Core.Models
{
    public class FrequentlyAskedQuestionModel
    {
               
        public string Question { get; set; } = null!;

        public string Answer { get; set; } = null!;

    }
}