using MediationCorner.Controllers;
using MediationCorner.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace MediationCorner.Areas.Admin.Controllers
{
    public class FAQController : AdminBaseController
    {

        private readonly IFAQService FAQService;

        public FAQController(IFAQService _FAQService)
        {
            FAQService = _FAQService;
        }
        private const int PageSize = 2;

        public async Task<IActionResult> AllFAQ(int page = 1)
        {
            var allFAQ = await FAQService.AllAsync();
            int totalItems = allFAQ.Count();
            int totalPages = (int)Math.Ceiling((double)totalItems / PageSize);


            var model = allFAQ.Skip((page - 1) * PageSize).Take(PageSize).ToList();



            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            return View(model);
        }

        public async Task<IActionResult> Add()
        {
            return View();
        }
    }
}