using MediationCorner.Core.Models.Inquiry;
using MediationCorner.Core.Models.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediationCorner.Core.Contracts
{
    public interface IInquiryService
    {
        Task<IEnumerable<InquiryViewModel>> AllAsync();
        Task<IEnumerable<InquiryViewModel>> AllByIdAsync(string id);
        Task CreateAsync(InquiryFormModel model, string id);
        Task CreateResponseAsync(ResponseFormModel model, int inquiryId);

    }
}
