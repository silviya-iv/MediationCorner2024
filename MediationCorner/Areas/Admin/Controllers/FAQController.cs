using Microsoft.AspNetCore.Mvc;

namespace MediationCorner.Areas.Admin.Controllers
{
    public class FAQController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
