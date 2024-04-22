using Microsoft.AspNetCore.Mvc;

namespace MediationCorner.Controllers
{
    public class AppointmentController : BaseController
    {
        public IActionResult Mine()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
