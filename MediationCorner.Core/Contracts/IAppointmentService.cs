using MediationCorner.Core.Models.Appointment;
using MediationCorner.Infrastructure.Data.Models;

namespace MediationCorner.Core.Contracts
{
    public interface IAppointmentService
 
{
    Task<IEnumerable<AppointmentViewModel>> AllAsync();
    Task<IEnumerable<AppointmentViewModel>> AllByIdAsync(string id);
    Task CreateAsync(AppointmentFormModel model, string id);
    Task DeleteAsync(int id);
    Task<bool> IsTimeSlotOccupied(DateTime startTime, DateTime endTime);

}

}
