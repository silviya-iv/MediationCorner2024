using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediationCorner.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FrequentlyAskedQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Question identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Question"),
                    Answer = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "Response to question")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrequentlyAskedQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lecturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Lecturer identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "Lecturer's name"),
                    Summary = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "Lecturer's summary"),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true, comment: "Lecturer photo")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Appointment identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Reason for the appointment"),
                    ClientId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Client"),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Starting time of the appointment"),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "End time for the appointment")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_AspNetUsers_ClientId",
                        column: x => x.ClientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inquiries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Inquiry identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Inquiry title"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "Inquiry description"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true, comment: "Inquiry initiator's phone number "),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the iquiry initiation"),
                    InitiatorId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Iquiry initiator")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquiries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inquiries_AspNetUsers_InitiatorId",
                        column: x => x.InitiatorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MediationRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Request identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstPartyId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Initiator of the mediation request"),
                    firstPartyPhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Initiator's phone number"),
                    SecondPartyName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "Second party name"),
                    ShortDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "Description of the mediation request")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediationRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MediationRequests_AspNetUsers_FirstPartyId",
                        column: x => x.FirstPartyId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seminars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Seminar identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Seminar title"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Seminar description"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the seminar"),
                    Location = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Location where the seminar will take place"),
                    Price = table.Column<decimal>(type: "decimal(6,2)", nullable: false, comment: "Price for attending the seminar"),
                    RegistrationDeadline = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Deadline for sign up for the seminar"),
                    LecturerId = table.Column<int>(type: "int", nullable: false, comment: "Lecturer of the seminar")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seminars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seminars_Lecturers_LecturerId",
                        column: x => x.LecturerId,
                        principalTable: "Lecturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Response identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InquiryResponse = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "Response to inquiry"),
                    DateOfResponse = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the response"),
                    InquiryId = table.Column<int>(type: "int", nullable: false, comment: "Inquiry identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Responses_Inquiries_InquiryId",
                        column: x => x.InquiryId,
                        principalTable: "Inquiries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgressStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Current status identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the status"),
                    CurrrentStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Current status of the mediation request"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Current status description"),
                    MediationRequestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgressStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgressStatuses_MediationRequests_MediationRequestId",
                        column: x => x.MediationRequestId,
                        principalTable: "MediationRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersSeminars",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User identifier"),
                    SeminarId = table.Column<int>(type: "int", nullable: false, comment: "Seminar identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersSeminars", x => new { x.UserId, x.SeminarId });
                    table.ForeignKey(
                        name: "FK_UsersSeminars_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersSeminars_Seminars_SeminarId",
                        column: x => x.SeminarId,
                        principalTable: "Seminars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "35be685d-b14d-488c-81ce-5edce94e0b33", "client2@gmail.com", false, "Петър", "Петров", false, null, "CLIENT2@GMAIL.COM", "CLIENT2@GMAIL.COM", "AQAAAAEAACcQAAAAEC3dTLvg4tUDVBS/WaVuc3WXosNo/NFDv6YOo2dxqn2J9ErwCoyhj5ttS1Fqj5SJlQ==", null, false, "9e9a3770-ddd0-42fa-9f47-30fe80096cc8", false, "client2@gmail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "f1e49245-136c-4f3c-ac7d-9d7322a82e72", "client1@gmail.com", false, "Иван", "Иванов", false, null, "CLIENT1@GMAIL.COM", "CLIENT1@GMAIL.COM", "AQAAAAEAACcQAAAAENiO1KQ3AWvnwus1FjqiJmaJp+Gb6VzZKnXADawa1TOCPxrK5Sm/k3iM2BCJs2uEPg==", null, false, "ed369ee8-777a-4c6a-9b5a-98e1498754ee", false, "client1@gmail.com" },
                    { "e43ce836-997d-4927-ac59-74e8c41bbfd3", 0, "15d53adb-3758-47de-8216-c3dd84669dd3", "mediation.law.corner@gmail.com", false, "Вероника", "Иванова", false, null, "MEDIATION.LAW.CORNER@GMAIL.COM", "MEDIATION.LAW.CORNER@GMAIL.COM", "AQAAAAEAACcQAAAAEO5WMMZA5lEWnLqOVJW493NuJtzOETLl6WoBqe/CdVVy4um2iVQ82NZ9tnJi/0Srjw==", null, false, "f865b136-ac82-4129-ba3a-08870bc45ea8", false, "mediation.law.corner@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "FrequentlyAskedQuestions",
                columns: new[] { "Id", "Answer", "Question" },
                values: new object[,]
                {
                    { 1, "Целта на нашата платформа за посредничество е да осигурим ефективен и бърз начин за решаване на спорове и конфликти. Чрез нашата услуга можете да намерите квалифицирани посредници, да инициирате процеса на посредничество и да управлявате вашия случай онлайн.", "Каква е целта на тази платформа за посредничество?" },
                    { 2, "Първо, регистрирате профил и предоставяте информация за вашия спор. След това, системата ще ви предложи квалифицирани посредници, които отговарят на вашите нужди. След като изберете посредник, можете да започнете процеса на посредничество, който включва комуникация между страните и търсене на решение на спора.", "Как работи процесът на посредничество чрез тази платформа?" },
                    { 3, "Посредничеството предлага множество предимства, включително по-бързо и по-ефективно решаване на спорове, по-ниски разходи, по-добро запазване на отношенията между страните и по-голяма гъвкавост в процеса на вземане на решения.", "Какви са предимствата на посредничеството пред съдебния процес?" }
                });

            migrationBuilder.InsertData(
                table: "Lecturers",
                columns: new[] { "Id", "Name", "Photo", "Summary" },
                values: new object[] { 1, "Доц. д-р Стефан Иванов", null, "Доц. д-р Стефан Иванов е известен правен учен с богат опит в преподаването и научните изследвания. Той притежава докторска степен по право от Софийски университет и се специализира в областта на международното право, правата на човека и сравнителните правни системи. Доц. Иванов е автор на множество статии в престижни правни списания и е представял своите изследвания на международни конференции. Той е бил гост-лектор в реномирани университети в Европа и е бил поканен да проведе ключови речи на различни семинари с правна тематика. Експертизата и страстта на доц. Иванов към правното образование го правят неоценим ресурс за студенти и професионалисти." });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "ClientId", "EndTime", "ShortDescription", "StartTime" },
                values: new object[,]
                {
                    { 1, "dea12856-c198-4129-b3f3-b893d8395082", new DateTime(2024, 4, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), "Консултация относно посредничство", new DateTime(2024, 4, 30, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", new DateTime(2024, 4, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), "Консултация от относно развод", new DateTime(2024, 4, 30, 13, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "FirstName", "Иван", "dea12856-c198-4129-b3f3-b893d8395082" },
                    { 2, "FirstName", "Петър", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" },
                    { 3, "FirstName", "Вероника", "e43ce836-997d-4927-ac59-74e8c41bbfd3" }
                });

            migrationBuilder.InsertData(
                table: "Inquiries",
                columns: new[] { "Id", "Date", "Description", "InitiatorId", "PhoneNumber", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 21, 16, 3, 16, 103, DateTimeKind.Local).AddTicks(4562), "Здравейте, искам да се консултирам относно наемния договор, който подписах с наемодателя си за жилище. Имам няколко въпроса относно правата и задълженията ми като наемател и какви са моите права, ако се появи спор между мен и наемодателя. Благодаря ви предварително за съдействието.", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", "00359887654321", "Въпроси относно наемния договор за жилище" },
                    { 2, new DateTime(2024, 4, 21, 16, 3, 16, 103, DateTimeKind.Local).AddTicks(4615), "важаеми, имаме няколко въпроса относно прилагането на трудовия закон в нашата фирма. Искаме консултация относно правилата за работно време, отпуските, както и процедурите за уволнение и компенсации. Моля, свържете се с нас, за да уговорим среща за консултация. Благодарим ви.", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", "00359887654321", "Въпрос относно прилагането на трудовия закон" }
                });

            migrationBuilder.InsertData(
                table: "MediationRequests",
                columns: new[] { "Id", "FirstPartyId", "SecondPartyName", "ShortDescription", "firstPartyPhoneNumber" },
                values: new object[,]
                {
                    { 1, "dea12856-c198-4129-b3f3-b893d8395082", "Георги Георгиев", "Имаме спор със съседите за границите на имота.", "00359883456789" },
                    { 2, "dea12856-c198-4129-b3f3-b893d8395082", "Мария Илиева", "Необходима е помощ за разрешаване на договорен спор с доставчик.", "00359883456789" }
                });

            migrationBuilder.InsertData(
                table: "Seminars",
                columns: new[] { "Id", "Date", "Description", "LecturerId", "Location", "Price", "RegistrationDeadline", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Описание: Семинарът ще обхване теми като правата на наследниците, разпределение на наследството, процедурите за наследствено дело и правните аспекти при разрешаване на спорове относно наследството. Събитето ще се проведе от 09:00 и ще бъде с продължи до 12:30", 1, "гр. Благоевград, Американски Университет, Зала 3", 150.00m, new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Наследствено право и процесуални аспекти" },
                    { 2, new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Описание: Семинарът ще представи основните правила на Общия регламент за защита на данните (GDPR) и техния принос към защитата на личните данни в бизнес средата. Ще се разгледат и случаи от практиката и съответните правни последици за организациите. Събитето ще се проведе от 09:00 и ще бъде с продължи до 12:30", 1, "гр. Благоевград, Американски Университет, Зала 3", 150.00m, new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приложение на GDPR в бизнеса: Законодателство и регулации  " }
                });

            migrationBuilder.InsertData(
                table: "ProgressStatuses",
                columns: new[] { "Id", "CurrrentStatus", "Date", "Description", "MediationRequestId" },
                values: new object[,]
                {
                    { 1, "В процес на посредничество", new DateTime(2024, 4, 21, 16, 3, 16, 267, DateTimeKind.Local).AddTicks(8534), "Насрочена е дата за среща с двете страни", 1 },
                    { 2, "Изчакване", new DateTime(2024, 4, 21, 16, 3, 16, 267, DateTimeKind.Local).AddTicks(8538), "Изчакваме обратна връзка от втората страна по конфликта", 2 }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "DateOfResponse", "InquiryId", "InquiryResponse" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 21, 16, 3, 16, 317, DateTimeKind.Local).AddTicks(8177), 1, "Като наемател имате право да използвате наетото жилище в съответствие с условията на договора за наем.Имате право да живеете в жилище, което е подходящо за живеене и отговаря на минималните здравни и санитарни изисквания. Имате право на мирно ползване на жилището и на неприкосновеност на вашето лично пространство.На наемодателя му се изисква да осигури сигурно жилище и да извършва необходимите ремонти, за да запази жилището в добро състояние. Ако има спор между вас и наемодателя, имате право да потърсите правна помощ и да обжалвате решенията на компетентните органи или съдилища. Можете да ползвате процедури за алтернативно разрешаване на спорове, като например медиация или арбитраж, за да решите спора извън съдебен път." },
                    { 2, new DateTime(2024, 4, 21, 16, 3, 16, 317, DateTimeKind.Local).AddTicks(8185), 2, "Здравейте, можете да запазите час за консултация през формата в сайта, като влезете в меню Запази час за консултация." }
                });

            migrationBuilder.InsertData(
                table: "UsersSeminars",
                columns: new[] { "SeminarId", "UserId" },
                values: new object[,]
                {
                    { 1, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" },
                    { 2, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" },
                    { 1, "dea12856-c198-4129-b3f3-b893d8395082" },
                    { 2, "dea12856-c198-4129-b3f3-b893d8395082" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ClientId",
                table: "Appointments",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_StartTime",
                table: "Appointments",
                column: "StartTime",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Inquiries_InitiatorId",
                table: "Inquiries",
                column: "InitiatorId");

            migrationBuilder.CreateIndex(
                name: "IX_MediationRequests_FirstPartyId",
                table: "MediationRequests",
                column: "FirstPartyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressStatuses_MediationRequestId",
                table: "ProgressStatuses",
                column: "MediationRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_InquiryId",
                table: "Responses",
                column: "InquiryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seminars_LecturerId",
                table: "Seminars",
                column: "LecturerId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersSeminars_SeminarId",
                table: "UsersSeminars",
                column: "SeminarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "FrequentlyAskedQuestions");

            migrationBuilder.DropTable(
                name: "ProgressStatuses");

            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "UsersSeminars");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "MediationRequests");

            migrationBuilder.DropTable(
                name: "Inquiries");

            migrationBuilder.DropTable(
                name: "Seminars");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Lecturers");
        }
    }
}
