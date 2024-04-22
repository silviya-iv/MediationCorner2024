using Microsoft.AspNetCore.Mvc;

namespace MediationCorner.Areas.Admin.Controllers
{
    public class AppointmentController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
