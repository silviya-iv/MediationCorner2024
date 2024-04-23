using MediationCorner.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediationCorner.Core.Contracts
{
    public interface IFAQService

    {
        Task CreateAsync(FrequentlyAskedQuestionFormModel model);

        Task<FrequentlyAskedQuestionModel> AllAsync(
            string? searchTerm = null,
            int currentPage = 1,
            int FAQPerPage = 1);

        Task EditAsync(int FAQId, FrequentlyAskedQuestionFormModel model);

        Task DeleteAsync(int FAQId);


    }

    
}
