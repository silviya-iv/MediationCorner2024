using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediationCorner.Core.Models.Appointment
{
    public class AppointmentViewModel
    {
        public string ShortDesription { get; set; } = null!;

        public string ClientId { get; set; } = null!;

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

    }
}
