using Microsoft.AspNetCore.Mvc;

namespace MediationCorner.Areas.Admin.Controllers
{
    public class LecturerController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
