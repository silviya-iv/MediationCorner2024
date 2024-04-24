using Microsoft.AspNetCore.Mvc;

namespace MediationCorner.Areas.Admin.Controllers
{
    public class InquiryController : AdminBaseController
    {
        public IActionResult All()
        {
            return View();
        }
    } 
}
