using MediationCorner.Core.Contracts;
using MediationCorner.Core.Models.FAQ;
using MediationCorner.Infrastructure.Common;
using MediationCorner.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace MediationCorner.Core.Services
{
    public class FAQService : IFAQService
    {
        private readonly IRepository repository;

        public FAQService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<IEnumerable<FrequentlyAskedQuestionModel>> AllAsync()
        {
            return await repository.All<FrequentlyAskedQuestion>()
                .Select(f => new FrequentlyAskedQuestionModel()
                {
                    Id=f.Id,
                    Question = f.Question,
                    Answer = f.Answer
                })

                .ToListAsync();

        }
        public async Task CreateAsync(FrequentlyAskedQuestionFormModel model)
        {
            FrequentlyAskedQuestion faq = new FrequentlyAskedQuestion()
            {
                Question = model.Question,
                Answer = model.Answer
            };

            await repository.AddAsync(faq);
            await repository.SaveChangesAsync();
        }


        public async Task DeleteAsync(int faqId)
        {
            await repository.DeleteAsync<FrequentlyAskedQuestion>(faqId);
            await repository.SaveChangesAsync();
        }

        public async Task EditAsync(int faqId, FrequentlyAskedQuestionFormModel model)
        {
            var faq = await repository.GetByIdAsync<FrequentlyAskedQuestion>(faqId);

            if (faq != null)
            {
                faq.Question = model.Question;
                faq.Answer = model.Answer;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await repository.AllReadOnly<FrequentlyAskedQuestion>()
                .AnyAsync(h => h.Id == id);
        }
        public async Task<FrequentlyAskedQuestionModel> FaqById(int id)
        {
            return await repository.AllReadOnly<FrequentlyAskedQuestion>()
                .Where(h => h.Id == id)
                .Select(h => new FrequentlyAskedQuestionModel()
                {
                    Question = h.Question,
                    Answer = h.Answer
                })
                .FirstAsync();
        }


    }
}