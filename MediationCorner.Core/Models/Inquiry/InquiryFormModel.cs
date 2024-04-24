using System.ComponentModel.DataAnnotations;
using static MediationCorner.Core.Constants.MessageConstants;
using static MediationCorner.Infrastructure.DataConstants.ValidationConstants;

namespace MediationCorner.Core.Models.Inquiry
{
    public class InquiryFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(InquiryTitleMaxLength,
        MinimumLength = InquiryTitleMinLength,
        ErrorMessage = LengthMessage)]
        [Display(Name = "Заглавие")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(InquiryDescriptionMaxLength,
       MinimumLength = InquiryDescriptionMinLength,
       ErrorMessage = LengthMessage)]
        [Display(Name = "Описание")]
         public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(InitiatorPhoneMaxLength,
       MinimumLength = InitiatorPhoneMinLength,
       ErrorMessage = LengthMessage)]
        [Phone]
        [Display(Name = "Телефонен номер")]
        public string PhoneNumber { get; set; } = string.Empty;

    }
}
