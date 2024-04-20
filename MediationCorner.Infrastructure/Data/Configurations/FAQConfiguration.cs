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
    internal class FAQConfiguration : IEntityTypeConfiguration<FrequentlyAskedQuestion>
    {
        public void Configure(EntityTypeBuilder<FrequentlyAskedQuestion> builder)
        {
            var data = new SeedData();
            builder.HasData(new FrequentlyAskedQuestion[] { data.Purpose, data.Pros, data.HowToUse });
        }
    }
}
