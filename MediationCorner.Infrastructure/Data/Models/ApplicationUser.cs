using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static MediationCorner.Infrastructure.DataConstants.ValidationConstants;

namespace MediationCorner.Infrastructure.Data.Models
{
    public class ApplicationUser: IdentityUser
    {
            [Required]
            [StringLength(AppUserFirstNameMaxLength)]
            [PersonalData]
            public string FirstName { get; set; } = string.Empty;

            [Required]
            [StringLength(AppUserLastNameMaxLength)]
            [PersonalData]
            public string LastName { get; set; } = string.Empty;
        
    }
}
