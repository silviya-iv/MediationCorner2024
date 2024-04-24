using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MediationCorner.Core.Models.Responce
{
    public class ResponseViewModel
    {
        [Display(Name = "Отговор")]
        public string InquiryResponse { get; set; } = null!;

        [Display(Name = "Дата на отговора")]
         public DateTime DateOfResponse { get; set; } = DateTime.Now;

    }
}
