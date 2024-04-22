using Microsoft.AspNetCore.Mvc;

namespace MediationCorner.Areas.Admin.Controllers
{
    public class SeminarController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
