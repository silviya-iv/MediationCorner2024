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
            return await repository.AllReadOnly<FrequentlyAskedQuestion>()
                .Select(f => new FrequentlyAskedQuestionModel()
                {
                    Question = f.Question,
                    Answer = f.Answer
                })

                .ToListAsync();

        }
        public Task CreateAsync(FrequentlyAskedQuestionFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int FAQId)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(int FAQId, FrequentlyAskedQuestionFormModel model)
        {
            throw new NotImplementedException();
        }

        
    }
}