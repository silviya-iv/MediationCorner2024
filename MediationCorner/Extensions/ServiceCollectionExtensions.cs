using MediationCorner.Infrastructure.Common;
using MediationCorner.Infrastructure.Data.Models;
using MediationCorner.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MediationCorner.Core.Contracts;
using MediationCorner.Core.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAppointmentService, AppointmentService>();
            services.AddScoped<IFAQService, FAQService>();
            services.AddScoped<IInquiryService, InquiryService>();
            services.AddScoped<ILecturerService, LecturerService>();
            services.AddScoped<IMediationRequestService, MediationRequestService>();
            services.AddScoped<IProgressStatusService, ProgressStatusService>();
            services.AddScoped<IResponceService, ResponceService>();
            services.AddScoped<ISeminarService, SeminarService>();
            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<MediationCornerDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IRepository, Repository>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddDefaultIdentity<ApplicationUser>(options =>
                {
                    options.User.RequireUniqueEmail = true;
                    options.Password.RequireNonAlphanumeric = true;
                    options.Password.RequireDigit = true;
                    options.Password.RequireLowercase = true;
                    options.Password.RequireUppercase = true;
                })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<MediationCornerDbContext>();

            return services;
        }
    }
}
