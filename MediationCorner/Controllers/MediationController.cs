using Microsoft.AspNetCore.Mvc;

namespace MediationCorner.Controllers
{
    public class MediationController : BaseController
    {
        public IActionResult Mine()
        {
            return View();
        }
    }
}
