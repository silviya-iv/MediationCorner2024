using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediationCorner.Infrastructure.DataConstants
{
    public class ValidationConstants
    {
        public const int AppUserFirstNameMinLength = 2;
        
        public const int AppUserFirstNameMaxLength = 50;

        public const int AppUserLastNameMinLength = 2;
        
        public const int AppUserLastNameMaxLength = 50;

        public const int AppointmentDescriptionMinLength = 10;
        
        public const int AppointmentDescriptionMaxLength = 50;

        public const int FAQMinLength = 30;
        
        public const int FAQMaxLength = 200;

        public const int FAQResponseMinLength = 200;
        
        public const int FAQResponseMaxLength = 1000;

        public const int InquiryTitleMinLength = 20;
        
        public const int InquiryTitleMaxLength = 100;

        public const int InquiryDescriptionMinLength = 100;
        
        public const int InquiryDescriptionMaxLength = 1000;

        public const int InquiryAnswerMinLength = 50;
        
        public const int InquiryAnswerMaxLength = 1000;

        public const int InitiatorPhoneMinLength = 7;
        
        public const int InitiatorPhoneMaxLength = 15;

        public const int MediationRequestStatusMinLength = 10;
        
        public const int MediationRequestStatusMaxLengt = 50;

        public const int MediationRequestStatusDescriptoionMinLength = 30;
        
        public const int MediationRequestStatusDescriptoionMaxLengt = 100;

        public const int SeminarTitleMinLength = 5;
        
        public const int SeminarTitleMaxLength = 100;

        public const int SeminarDescriptionMinLength = 10;
        
        public const int SeminarDescriptionMaxLength = 500;

        public const int SeminarLocationMinLength = 30;
        
        public const int SeminarLocationMaxLength = 150;

        public const string SeminarPriceMin = "30";
    
        public const string SeminarPriceMax = "200";

        public const int SecondPartyNameMinLength = 5;
        
        public const int SecondPartyNameMaxLength = 60;

        public const int MediationRequestDescriptionMinLength = 100;
        
        public const int MediationRequestDescriptionMaxLength = 1000;

        public const int LecturerNameMinLength = 5;
        
        public const int LecturerNameMaxLength = 60;

        public const int LecturerSummaryMinLength = 100;
        
        public const int LecturerSummaryMaxLength = 1000;

        public const string DateFormat = "dd/MM/yyyy HH:mm";
    }
}
