using MediationCorner.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace MediationCorner.Infrastructure.Data
{
    public class MediationCornerDbContext : IdentityDbContext<ApplicationUser>
    {
        public MediationCornerDbContext(DbContextOptions<MediationCornerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; } = null!;
        public DbSet<Inquiry> FrequentlyAskedQuestions { get; set; } = null!;
        public DbSet<Inquiry> Inquiries { get; set; } = null!;
        public DbSet<Lecturer> Lecturers { get; set; } = null!;
        public DbSet<MediationRequest> MediationRequests { get; set; } = null!;
        public DbSet<Response> Responses { get; set; } = null!;
        public DbSet<Seminar> Seminars { get; set; } = null!;
        public DbSet<UserSeminar> UsersSeminars { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserSeminar>()
                .HasKey(us => new { us.UserId, us.SeminarId });

            builder.Entity<UserSeminar>()
                .HasOne(s =>s.Seminar)
                .WithMany(us => us.UsersSeminars)
                .OnDelete(DeleteBehavior.Restrict);
        }
        }
    }