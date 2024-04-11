using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediationCorner.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Appointment identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Reason for the appointment"),
                    ClientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "Inquiries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Inquiry identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Inquiry title"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "Inquiry description"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true, comment: "Inquiry initiator's phone number "),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the iquiry initiation"),
                    InitiatorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquiries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inquiries_AspNetUsers_InitiatorId",
                        column: x => x.InitiatorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                name: "MediationRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Request identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstPartyId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "Seminars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Seminar identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Seminar title"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Seminar description"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time of the seminar"),
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
                name: "IX_Inquiries_InitiatorId",
                table: "Inquiries",
                column: "InitiatorId");

            migrationBuilder.CreateIndex(
                name: "IX_MediationRequests_FirstPartyId",
                table: "MediationRequests",
                column: "FirstPartyId");

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
                name: "FrequentlyAskedQuestions");

            migrationBuilder.DropTable(
                name: "MediationRequests");

            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "UsersSeminars");

            migrationBuilder.DropTable(
                name: "Inquiries");

            migrationBuilder.DropTable(
                name: "Seminars");

            migrationBuilder.DropTable(
                name: "Lecturers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
