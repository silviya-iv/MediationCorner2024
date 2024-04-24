using MediationCorner.Core.Contracts;
using MediationCorner.Core.Models;
using MediationCorner.Core.Models.Appointment;
using MediationCorner.Infrastructure.Common;
using MediationCorner.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace MediationCorner.Core.Services
{
    public class AppointmentService:IAppointmentService
    {
        private readonly IRepository repository;

        public AppointmentService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<AppointmentViewModel>> AllAsync()
        {
            return await repository.All<Appointment>()
        .Select(a => new AppointmentViewModel()
        {
            ShortDesription = a.ShortDescription,
            StartTime = a.StartTime,
            EndTime = a.EndTime
        }).ToListAsync();
        }

        public async Task<IEnumerable<AppointmentViewModel>> AllByIdAsync(string id)
        {
            return await repository.All<Appointment>().Where(a=>a.ClientId==id)
        .Select(a => new AppointmentViewModel()
        {
            ShortDesription = a.ShortDescription,
            StartTime = a.StartTime,
            EndTime = a.EndTime
        }).ToListAsync();
        }

        public async Task CreateAsync(AppointmentFormModel appointment, string id)
        {
            Appointment app = new Appointment()
            {
                ShortDescription = appointment.ShortDescription,
                ClientId = id,
                StartTime = appointment.StartTime,
                EndTime = appointment.EndTime

            };

            await repository.AddAsync(app);
            await repository.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsynk(int id)
        {
            await repository.DeleteAsync<Appointment>(id);
            await repository.SaveChangesAsync();

        }

        
            public async Task<bool> IsTimeSlotOccupied(DateTime startTime, DateTime endTime)
        {
            var overlappingAppointments = await repository.AllReadOnly<Appointment>()
                .Where(a => !(endTime <= a.StartTime || startTime >= a.EndTime))
                .Select(a=>new AppointmentViewModel
                {
                    ShortDesription=a.ShortDescription,
                    ClientId = a.ClientId,
                    StartTime = a.StartTime,
                    EndTime = a.EndTime
                }).ToListAsync();

            return overlappingAppointments.Any();
        }
    }

}
