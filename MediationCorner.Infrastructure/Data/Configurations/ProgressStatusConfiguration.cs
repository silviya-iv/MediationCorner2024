using MediationCorner.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediationCorner.Infrastructure.Data.Configurations
{
    internal class ProgressStatusConfiguration : IEntityTypeConfiguration<ProgressStatus>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ProgressStatus> builder)
        {
            var data = new SeedData();

            builder.HasData(new ProgressStatus[] { data.InProgress, data.Awaiting });

        }
    }
}
