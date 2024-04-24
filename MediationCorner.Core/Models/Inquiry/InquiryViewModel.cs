using MediationCorner.Core.Models.Responce;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MediationCorner.Core.Models.Inquiry
{
    public class InquiryViewModel
    {
       public int Id { get; set; }

        [Display(Name = "Заглавие")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Описание")]
        public string Description { get; set; } = string.Empty;


        [Display(Name = "Телефонен номер")]
        public string PhoneNumber { get; set; } = string.Empty;


        [Display(Name = "Дата на запитването")]
        public DateTime Date { get; set; }

        [Display(Name = "Име")]
        public string InitiatorUserName { get; set; } = string.Empty;


        public ResponseViewModel? Response { get; set; }

    }
}
