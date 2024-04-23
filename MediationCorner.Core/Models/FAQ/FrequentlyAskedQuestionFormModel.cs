using System.ComponentModel.DataAnnotations;
using static MediationCorner.Core.Constants.MessageConstants;
using static MediationCorner.Infrastructure.DataConstants.ValidationConstants;

namespace MediationCorner.Core.Models.FAQ
{
    public class FrequentlyAskedQuestionFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(FAQMinLength,
        MinimumLength = FAQMaxLength,
        ErrorMessage = LengthMessage)]
        [Display(Name = "Въпрос")]
        public string Question { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(FAQMinLength,
        MinimumLength = FAQResponseMinLength,
        ErrorMessage = LengthMessage)]
        [Display(Name = "Отговор")]
        public string Answer { get; set; } = null!;

    }
}