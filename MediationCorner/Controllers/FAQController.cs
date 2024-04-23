using MediationCorner.Core.Models;
using MediationCorner.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace MediationCorner.Controllers
{
    public class FAQController : BaseController
    {

        private readonly MediationCornerDbContext _context;

        public FAQController(MediationCornerDbContext context)
        {
            _context = context;
        }

        // Action method for viewing all FAQs
        public IActionResult All()
        {
            var faqs = _context.FrequentlyAskedQuestions.Select(f=>new FrequentlyAskedQuestionModel { 
            Question=f.Question,
            Answer=f.Answer})
                .ToList();
                
            return View(faqs);
        }

        //public IActionResult All()
        //{

        //    return View();
        //}
    }
}
