using MediationCorner.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using static MediationCorner.Infrastructure.DataConstants.CustomClaims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediationCorner.Infrastructure.Data.Configurations
{
    internal class SeedData
    {
        public IdentityUserClaim<string> ClientUserOneClaim { get; set; }

        public IdentityUserClaim<string> ClientUserTwoClaim { get; set; }

        public IdentityUserClaim<string> AdminUserClaim { get; set; }

        public ApplicationUser ClientUserOne { get; set; }

        public ApplicationUser ClientUserTwo { get; set; }

        public ApplicationUser AdminUser { get; set; }
        
        public Appointment DivorceConsultation { get; set; }

        public Appointment MediationConsultation { get; set; }

        public FrequentlyAskedQuestion Purpose { get; set; }

        public FrequentlyAskedQuestion Pros { get; set; }

        public FrequentlyAskedQuestion HowToUse { get; set; }

        public Inquiry Rent { get; set; }

        public Inquiry LabourLaw { get; set; }

        public Lecturer Lecturer { get; set; }

        public MediationRequest Neighbours { get; set; }

        public MediationRequest Supplier { get; set; }

        public ProgressStatus InProgress { get; set; }

        public ProgressStatus Awaiting { get; set; }

        public Response ResponseRent { get; set; }

        public Response ResponseToLabourLaw { get; set; }

        public Seminar Inheritance { get; set; }

        public Seminar GDPR { get; set; }

        public UserSeminar UserOneSeminarGDPR { get; set; }

        public UserSeminar UserTwoSeminarGDPR { get; set; }

        public UserSeminar UserOneSeminarInheritance { get; set; }

        public UserSeminar UserTwoSeminarInheritance { get; set; }

        public SeedData() 
        {
            SeedUsers();
            SeedLecturers();
            SeedFrequentlyAskedQuestion();
            SeedAppointments();
           
            SeedInquiry();
            
            SeedMediationRequests();
            SeedSeminars();
           
            SeedUsersSeminars();
            SeedResponse();
            SeedProgressStatus();
        }

        
        private void SeedUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            ClientUserOne = new ApplicationUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "client1@gmail.com",
                NormalizedUserName = "CLIENT1@GMAIL.COM",
                Email = "client1@gmail.com",
                NormalizedEmail = "CLIENT1@GMAIL.COM",
                FirstName = "Иван",
                LastName = "Иванов"
            };

            ClientUserOneClaim = new IdentityUserClaim<string>()
            {
                Id = 1,
                ClaimType = UserNameClaim,
                ClaimValue = "Иван",
                UserId = "dea12856-c198-4129-b3f3-b893d8395082"
            };

            ClientUserOne.PasswordHash =
                 hasher.HashPassword(ClientUserOne, "Client1Mediation");

            ClientUserTwo = new ApplicationUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "client2@gmail.com",
                NormalizedUserName = "CLIENT2@GMAIL.COM",
                Email = "client2@gmail.com",
                NormalizedEmail = "CLIENT2@GMAIL.COM",
                FirstName = "Петър",
                LastName = "Петров"
            };

            ClientUserTwoClaim = new IdentityUserClaim<string>()
            {
                Id = 2,
                ClaimType = UserNameClaim,
                ClaimValue = "Петър",
                UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
            };

            ClientUserTwo.PasswordHash =
            hasher.HashPassword(ClientUserTwo, "Client2Law");

            AdminUser = new ApplicationUser()
            {
                Id = "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                UserName = "mediation.law.corner@gmail.com",
                NormalizedUserName = "MEDIATION.LAW.CORNER@GMAIL.COM",
                Email = "mediation.law.corner@gmail.com",
                NormalizedEmail = "MEDIATION.LAW.CORNER@GMAIL.COM",
                FirstName = "Вероника",
                LastName = "Иванова"
            };

            AdminUserClaim = new IdentityUserClaim<string>()
            {
                Id = 3,
                ClaimType = UserNameClaim,
                UserId = "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                ClaimValue = "Вероника"
            };

            AdminUser.PasswordHash =
            hasher.HashPassword(AdminUser, "V@ronika1");
        }

        private void SeedSeminars()
        {
            Inheritance = new Seminar()
            {
                Id = 1,
                Title = "Наследствено право и процесуални аспекти",
                Description = "Описание: Семинарът ще обхване теми като правата на наследниците, разпределение на наследството, процедурите за наследствено дело и правните аспекти при разрешаване на спорове относно наследството. Събитето ще се проведе от 09:00 и ще бъде с продължи до 12:30",
                Date = new DateTime(2024, 10, 7),
                Location = "гр. Благоевград, Американски Университет, Зала 3",
                Price = 150.00M,
                RegistrationDeadline = new DateTime(2024, 09, 20),
                LecturerId = 1
            };

            GDPR = new Seminar()
            {
                Id = 2,
                Title = "Приложение на GDPR в бизнеса: Законодателство и регулации  ",
                Description = "Описание: Семинарът ще представи основните правила на Общия регламент за защита на данните (GDPR) и техния принос към защитата на личните данни в бизнес средата. Ще се разгледат и случаи от практиката и съответните правни последици за организациите. Събитето ще се проведе от 09:00 и ще бъде с продължи до 12:30",
                Date = new DateTime(2024, 11, 12),
                Location = "гр. Благоевград, Американски Университет, Зала 3",
                Price = 150.00M,
                RegistrationDeadline = new DateTime(2024, 10, 25),
                LecturerId = 1
            };
        }

        private void SeedMediationRequests()
        {
            Neighbours = new MediationRequest()
            {
                Id=1,
                FirstPartyId = ClientUserOne.Id,
                firstPartyPhoneNumber = "00359883456789",
                SecondPartyName = "Георги Георгиев",
                ShortDescription = "Имаме спор със съседите за границите на имота."
            };

            Supplier = new MediationRequest()
            {
                Id=2,
                FirstPartyId = ClientUserOne.Id,
                firstPartyPhoneNumber = "00359883456789",
                SecondPartyName = "Мария Илиева",
                ShortDescription = "Необходима е помощ за разрешаване на договорен спор с доставчик."
            };
        }

        private void SeedLecturers()
        {
            Lecturer = new Lecturer()
            {
                Id=1,
                Name = "Доц. д-р Стефан Иванов",
                Summary = "Доц. д-р Стефан Иванов е известен правен учен с богат опит в преподаването и научните изследвания. Той притежава докторска степен по право от Софийски университет и се специализира в областта на международното право, правата на човека и сравнителните правни системи. Доц. Иванов е автор на множество статии в престижни правни списания и е представял своите изследвания на международни конференции. Той е бил гост-лектор в реномирани университети в Европа и е бил поканен да проведе ключови речи на различни семинари с правна тематика. Експертизата и страстта на доц. Иванов към правното образование го правят неоценим ресурс за студенти и професионалисти."
            };
        }

        private void SeedInquiry()
        {
            Rent = new Inquiry()
            {
                Id=1,
                InitiatorId=ClientUserTwo.Id,
                Title= "Въпроси относно наемния договор за жилище",
                Description= "Здравейте, искам да се консултирам относно наемния договор, който подписах с наемодателя си за жилище. Имам няколко въпроса относно правата и задълженията ми като наемател и какви са моите права, ако се появи спор между мен и наемодателя. Благодаря ви предварително за съдействието.",
                PhoneNumber="00359887654321",
            };

            LabourLaw = new Inquiry()
            {
                Id=2,
                InitiatorId=ClientUserTwo.Id,
                Title= "Въпрос относно прилагането на трудовия закон",
                Description= "важаеми, имаме няколко въпроса относно прилагането на трудовия закон в нашата фирма. Искаме консултация относно правилата за работно време, отпуските, както и процедурите за уволнение и компенсации. Моля, свържете се с нас, за да уговорим среща за консултация. Благодарим ви.",
                PhoneNumber= "00359887654321"

            };
        }

        private void SeedFrequentlyAskedQuestion()
        {
            Purpose =new FrequentlyAskedQuestion()
            {
                Id=1,
                Question= "Каква е целта на тази платформа за посредничество?",
                Answer= "Целта на нашата платформа за посредничество е да осигурим ефективен и бърз начин за решаване на спорове и конфликти. Чрез нашата услуга можете да намерите квалифицирани посредници, да инициирате процеса на посредничество и да управлявате вашия случай онлайн."
            };

            Pros = new FrequentlyAskedQuestion()
            {
                Id = 2,
                Question = "Как работи процесът на посредничество чрез тази платформа?",
                Answer= "Първо, регистрирате профил и предоставяте информация за вашия спор. След това, системата ще ви предложи квалифицирани посредници, които отговарят на вашите нужди. След като изберете посредник, можете да започнете процеса на посредничество, който включва комуникация между страните и търсене на решение на спора."
            };

            HowToUse = new FrequentlyAskedQuestion()
            {
                Id=3,
                Question= "Какви са предимствата на посредничеството пред съдебния процес?",
                Answer= "Посредничеството предлага множество предимства, включително по-бързо и по-ефективно решаване на спорове, по-ниски разходи, по-добро запазване на отношенията между страните и по-голяма гъвкавост в процеса на вземане на решения."
            };
        }

        private void SeedAppointments()
        {
            MediationConsultation = new Appointment()
            {
                Id = 1,
                ClientId = ClientUserOne.Id,
                ShortDescription = "Консултация относно посредничство",
                StartTime = new DateTime(2024, 04, 30, 10, 00, 00),
                EndTime = new DateTime(2024, 04, 30, 11, 00, 00),
            };

            DivorceConsultation = new Appointment()
            {
                Id = 2,
                ClientId = ClientUserTwo.Id,
                ShortDescription = "Консултация от относно развод",
                StartTime = new DateTime(2024, 04, 30, 13, 00, 00),
                EndTime = new DateTime(2024, 04, 25, 14, 00, 00),
            };
        }

        private void SeedProgressStatus()
        {
            InProgress = new ProgressStatus()
            {
                Id = 1,
                CurrrentStatus = "В процес на посредничество",
                Description = "Насрочена е дата за среща с двете страни",
                MediationRequestId = 1

            };

            Awaiting = new ProgressStatus()
            {

                Id = 2,
                CurrrentStatus = "Изчакване",
                Description = "Изчакваме обратна връзка от втората страна по конфликта",
                MediationRequestId = 2
            };
        }

        private void SeedResponse()
        {
            ResponseRent = new Response()
            {
                Id = 1,
                InquiryId = 1,
                InquiryResponse = "Като наемател имате право да използвате наетото жилище в " +
                "съответствие с условията на договора за наем." +
                "Имате право да живеете в жилище, " +
                "което е подходящо за живеене и отговаря на минималните здравни и санитарни " +
                "изисквания. Имате право на мирно ползване на жилището и на неприкосновеност на " +
                "вашето лично пространство." +
                "На наемодателя му се изисква да осигури сигурно жилище и да извършва " +
                "необходимите ремонти, за да запази жилището в добро състояние. " +
                "Ако има спор между вас и наемодателя, имате право да потърсите правна помощ " +
                "и да обжалвате решенията на компетентните органи или съдилища. Можете да ползвате" +
                " процедури за алтернативно разрешаване на спорове, като например медиация или " +
                "арбитраж, за да решите спора извън съдебен път."
            };

            ResponseToLabourLaw = new Response()
            {
                Id = 2,
                InquiryId = 2,
                InquiryResponse = "Здравейте, можете да запазите час за консултация през формата в сайта, като влезете в меню Запази час за консултация."
            };
        }

        private void SeedUsersSeminars()
        {
            UserOneSeminarGDPR = new UserSeminar()
            {
                UserId = ClientUserOne.Id,
                SeminarId = 2
            };

            UserTwoSeminarGDPR = new UserSeminar()
            {
                UserId = ClientUserTwo.Id,
                SeminarId = 2
            };

            UserOneSeminarInheritance = new UserSeminar()
            {
                UserId = ClientUserOne.Id,
                SeminarId = 1
            };
            UserTwoSeminarInheritance = new UserSeminar()
            {
                UserId = ClientUserTwo.Id,
                SeminarId = 1
            };
        }

    }
}
