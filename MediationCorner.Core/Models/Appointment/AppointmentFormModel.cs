using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static MediationCorner.Core.Constants.MessageConstants;
using static MediationCorner.Infrastructure.DataConstants.ValidationConstants;

namespace MediationCorner.Core.Models.Appointment
{
    public class AppointmentFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(AppointmentDescriptionMaxLength,
        MinimumLength = AppointmentDescriptionMinLength,
        ErrorMessage = LengthMessage)]
        [Display(Name = "Описание")]
        public string ShortDescription { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        public string ClientId { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name="Начален час")]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Краен час")]
        public DateTime EndTime { get; set; }


    }
}
