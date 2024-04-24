using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


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
