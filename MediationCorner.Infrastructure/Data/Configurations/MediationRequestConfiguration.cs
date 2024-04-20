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
    internal class MediationRequestConfiguration : IEntityTypeConfiguration<MediationRequest>
    {
        public void Configure(EntityTypeBuilder<MediationRequest> builder)
        {
            var data = new SeedData();

            builder.HasData(new MediationRequest[] { data.Neighbours, data.Supplier });

        }
    }
}
