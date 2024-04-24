using MediationCorner.Core.Models.FAQ;
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

        Task<IEnumerable<FrequentlyAskedQuestionModel>> AllAsync();

        Task EditAsync(int FAQId, FrequentlyAskedQuestionFormModel model);

        Task<bool> ExistsAsync(int id);
        Task<FrequentlyAskedQuestionModel> FaqById(int id);

        Task DeleteAsync(int FAQId);


    }

    
}
