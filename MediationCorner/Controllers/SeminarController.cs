using Microsoft.AspNetCore.Mvc;

namespace MediationCorner.Controllers
{
    public class SeminarController : BaseController
    {
        public IActionResult All()
        {
            return View();
        }
    }
}
