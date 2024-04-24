using MediationCorner.Core.Contracts;
using MediationCorner.Core.Models.Appointment;
using MediationCorner.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediationCorner.Controllers
{
    public class AppointmentController : BaseController
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        // Action method to render the scheduler view
        public IActionResult Index()
        {
            return View();
        }

        // Action method to fetch appointments from the database
        public async Task<IActionResult> All()
        {
            var appointments = await _appointmentService.AllAsync();
            return View(appointments);
        }

        public async Task<IActionResult> Mine()
        {
            string id = GetUserId();
            var appointments = await _appointmentService.AllByIdAsync(id);
            return View(appointments);
        }
        // Action method to add a new appointment
        [HttpPost]
        public async Task<IActionResult> Add(AppointmentFormModel model)
        {
            string id = GetUserId();
            if (!ModelState.IsValid)
            {
                // Validation failed, return to the view with validation errors
                return View("Index", model);
            }

            // Check if there is already an appointment for the specified time
            if (await _appointmentService.IsTimeSlotOccupied(model.StartTime, model.EndTime))
            {
                ModelState.AddModelError("", "An appointment already exists for the specified time.");
                return View("Index", model);
            }

        
        

       await  _appointmentService.CreateAsync(model, id);
        
        return RedirectToAction("Index");
    }

    // Action method to delete an appointment
    [HttpPost]
    public async Task<ActionResult> Delete(int id)
    {
       await _appointmentService.DeleteAsync(id);
        return RedirectToAction("Index");
    }
}

    }
