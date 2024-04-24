
using System.ComponentModel.DataAnnotations;
using static MediationCorner.Core.Constants.MessageConstants;
using static MediationCorner.Infrastructure.DataConstants.ValidationConstants;

namespace MediationCorner.Core.Models.Responce
{
    public class ResponseFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(InquiryDescriptionMaxLength,
       MinimumLength = InquiryDescriptionMinLength,
       ErrorMessage = LengthMessage)]
        [Display(Name = "Отговор")]
        public string InquiryResponse { get; set; } = null!;

        [Display(Name = "Дата на отговора")]
         public DateTime DateOfResponse { get; set; } = DateTime.Now;

        public int InquiryId { get; set; }

    }
}
