using Microsoft.AspNetCore.Mvc;

namespace MediationCorner.Controllers
{
    public class FAQController : BaseController
    {
        public IActionResult All()
        {
            return View();
        }
    }
}
