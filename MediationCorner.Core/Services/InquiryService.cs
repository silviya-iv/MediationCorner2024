using MediationCorner.Core.Contracts;
using MediationCorner.Core.Models.Appointment;
using MediationCorner.Core.Models.FAQ;
using MediationCorner.Core.Models.Inquiry;
using MediationCorner.Core.Models.Responce;
using MediationCorner.Infrastructure.Common;
using MediationCorner.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediationCorner.Core.Services
{
    public class InquiryService : IInquiryService

    {
        private readonly IRepository repository;

        public InquiryService(IRepository _repository)
        {
            repository = _repository;
        }

                public async Task<IEnumerable<InquiryViewModel>> AllAsync()
        {
            return await repository.All<Inquiry>()
                .Select(i => new InquiryViewModel()
                {
                    Id = i.Id,
                    Title = i.Title,
                    Description = i.Description,
                    InitiatorUserName = i.Initiator.FirstName,
                    PhoneNumber = i.PhoneNumber,
                    Date = i.Date,
                    Response = new Models.Responce.ResponseViewModel()
                    {
                        InquiryResponse = i.Response.InquiryResponse,
                        DateOfResponse = i.Response.DateOfResponse
                    }
                }).ToListAsync();
                           
        }

        public async Task<IEnumerable<InquiryViewModel>> AllByIdAsync(string id)
        {


            return await repository.All<Inquiry>().Where(i=>i.InitiatorId==id)
                .Select(i => new InquiryViewModel()
                {
                    Id = i.Id,
                    Title = i.Title,
                    Description = i.Description,
                    InitiatorUserName = i.Initiator.FirstName,
                    PhoneNumber = i.PhoneNumber,
                    Date = i.Date,
                    
                }).ToListAsync();
        }

        public async Task CreateAsync(InquiryFormModel model, string id)
        {
            Inquiry app = new Inquiry()
            {
               Title = model.Title,
                Description = model.Description,
                InitiatorId = id,
                PhoneNumber = model.PhoneNumber,
                Date = DateTime.Now
            };

            await repository.AddAsync(app);
            await repository.SaveChangesAsync();
        }

        public async Task CreateResponseAsync(ResponseFormModel model, int inquiryId)
        {
            Response app = new Response()
            {
                InquiryResponse = model.InquiryResponse,                
                DateOfResponse = DateTime.Now,
                InquiryId=inquiryId
            };

            await repository.AddAsync(app);
            await repository.SaveChangesAsync();
        }
    }
}
