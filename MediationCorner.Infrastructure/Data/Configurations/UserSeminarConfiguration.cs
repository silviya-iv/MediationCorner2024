using MediationCorner.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediationCorner.Infrastructure.Data.Configurations
{
    public class UserSeminarConfiguration : IEntityTypeConfiguration<UserSeminar>
    {
        public void Configure(EntityTypeBuilder<UserSeminar> builder)
        {
            var data = new SeedData();

            builder.HasData(new UserSeminar[] { data.UserOneSeminarGDPR, data.UserTwoSeminarGDPR, data.UserOneSeminarInheritance, data.UserTwoSeminarInheritance });
        }
    }
}
