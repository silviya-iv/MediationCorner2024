using MediationCorner.Core.Contracts;
using MediationCorner.Core.Models.FAQ;
using MediationCorner.Core.Models.Inquiry;
using MediationCorner.Core.Services;
using MediationCorner.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediationCorner.Controllers
{
    public class InquiryController : BaseController
    {
        private readonly IInquiryService _inquiryService;
        public InquiryController(IInquiryService inquiryService)
        {
            _inquiryService = inquiryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> All()
        {
            var inquiries = await _inquiryService.AllAsync();
            return View(inquiries);
        }

        public async Task<IActionResult> Mine()
        {
            string id = GetUserId();
            var inquiries = await _inquiryService.AllByIdAsync(id);
            return View(inquiries);
        }


        [HttpGet]
        public IActionResult Add()
        {
            var model = new InquiryFormModel();

            return View(model);
        }



        [HttpPost]
        public async Task<IActionResult> Add(InquiryFormModel model)
        {
            string id = GetUserId();
            if (ModelState.IsValid == false)
            {
                return View(model);
            }
            await _inquiryService.CreateAsync(model,  id);

            return RedirectToAction("Mine");
        }

    }
}
