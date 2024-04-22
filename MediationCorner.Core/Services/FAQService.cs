using MediationCorner.Core.Contracts;
using MediationCorner.Core.Models;
using MediationCorner.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediationCorner.Core.Services
{
    public class FAQService:IFAQService
    {
        public Task<FrequentlyAskedQuestionModel> AllAsync(string? searchTerm = null, int currentPage = 1, int FAQPerPage = 1)
        {
            throw new NotImplementedException();
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
