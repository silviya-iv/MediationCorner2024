using MediationCorner.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediationCorner.Infrastructure.Data.Configurations
{
    internal class SeedData
    {
        public IdentityUserClaim<string> ClientUserClaim { get; set; }
        public IdentityUserClaim<string> AdminUserClaim { get; set; }

        public ApplicationUser ClientUser { get; set; }
        public ApplicationUser AdminUser { get; set; }
        
        public Appointment DivorceConsultation { get; set; }

        public Appointment MediationConsultation { get; set; }

        public FrequentlyAskedQuestion Purpose { get; set; }

        public FrequentlyAskedQuestion Pros { get; set; }

        public FrequentlyAskedQuestion HowToUse { get; set; }

        public Inquiry Rent { get; set; }

        public Inquiry LabourLaw { get; set; }

        public Lecturer Lecturer { get; set; }

        public MediationRequest Neighbours { get; set; }

        public MediationRequest Supplier { get; set; }

        public ProgressStatus InProgress { get; set; }

        public ProgressStatus Awaiting { get; set; }

        public Response ResponseRent { get; set; }

        public Response ResponseToLabourLaw { get; set; }

        public Seminar Inheritance { get; set; }

        public Seminar GDPR { get; set; }


        public SeedData() { }
    }
}
