using MediationCorner.Core.Contracts;
using MediationCorner.Core.Models;
using MediationCorner.Core.Services;
using MediationCorner.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace MediationCorner.Controllers
{
    public class FAQController : BaseController
    {

        private readonly IFAQService FAQService;

        public FAQController(IFAQService _FAQService)
        {
            FAQService = _FAQService;
        }
        private const int PageSize = 2;
       
        public async Task<IActionResult> All(int page = 1)
        {
            var allFAQ = await FAQService.AllAsync();
            int totalItems = allFAQ.Count();
            int totalPages = (int)Math.Ceiling((double)totalItems / PageSize);

       
        var model = allFAQ.Skip((page - 1) * PageSize).Take(PageSize).ToList();

        
            
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            return View(model);
        }
    }
}
         

       
    
