using Microsoft.AspNetCore.Mvc;

namespace MediationCorner.Areas.Admin.Controllers
{
    public class MediationController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
