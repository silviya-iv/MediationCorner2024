using Microsoft.AspNetCore.Mvc;

namespace MediationCorner.Controllers
{
    public class InquiryController : BaseController
    {
        public IActionResult Mine()
        {
            return View();
        }
    }
}
