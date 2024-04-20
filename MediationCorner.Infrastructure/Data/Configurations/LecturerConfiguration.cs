using MediationCorner.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediationCorner.Infrastructure.Data.Configurations
{
    internal class LecturerConfiguration : IEntityTypeConfiguration<Lecturer>
    {
        public void Configure(EntityTypeBuilder<Lecturer> builder)
        {
            throw new NotImplementedException();
        }
    }
}
