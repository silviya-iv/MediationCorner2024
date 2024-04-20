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
    internal class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            var data = new SeedData();

            builder.HasData(new Appointment[] { data.DivorceConsultation, data.MediationConsultation });
        }
    }
}
