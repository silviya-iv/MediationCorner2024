﻿using System.ComponentModel.DataAnnotations;

namespace MediationCorner.Core.Models.FAQ
{
    public class FrequentlyAskedQuestionModel
    {
        public int Id { get; set; }

        [Display(Name = "Въпрос")]
        public string Question { get; set; } = null!;

        [Display(Name = "Отговор")]
        public string Answer { get; set; } = null!;


    }
}