using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediationCorner.Infrastructure.Data.Models
{
    public class ApplicationUser: IdentityUser
    {
            [Required]
            [PersonalData]
            public string FirstName { get; set; } = string.Empty;

            [Required]
            [PersonalData]
            public string LastName { get; set; } = string.Empty;
        
    }
}
