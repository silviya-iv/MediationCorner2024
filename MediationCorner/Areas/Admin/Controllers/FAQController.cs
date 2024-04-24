using MediationCorner.Controllers;
using MediationCorner.Core.Contracts;
using MediationCorner.Core.Models.FAQ;
using MediationCorner.Infrastructure.Common;
using MediationCorner.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Printing;
using System.Security.Claims;

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

       

        [HttpGet]
        public  IActionResult Add()
        {
            var model = new FrequentlyAskedQuestionFormModel();

            return View(model);
        }



        [HttpPost]
        public async Task<IActionResult> Add(FrequentlyAskedQuestionFormModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }
            await FAQService.CreateAsync(model);

           return RedirectToAction("All", "FAQ");
         }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (await FAQService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (User.IsAdmin() == false)
            {
                return Unauthorized();
            }

            var faq = await FAQService.FaqById(id);

            var model = new FrequentlyAskedQuestionModel()
            {
                Question = faq.Question,
                Answer = faq.Answer,
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(FrequentlyAskedQuestionModel model)
        {
            if (await FAQService.ExistsAsync(model.Id) == false)
            {
                return BadRequest();
            }

            if (User.IsAdmin() == false)
            {
                return Unauthorized();
            }

            await FAQService.DeleteAsync(model.Id);

            return RedirectToAction("All", "FAQ");
        }

    }
}