using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediationCorner.Infrastructure.Migrations
{
    public partial class ClaimType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "ClaimType",
                value: "user:firstName");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClaimType",
                value: "user:firstName");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "ClaimType",
                value: "user:firstName");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "647d3c3e-fe54-4ae6-97c5-8b9f0ddf7e6c", "AQAAAAEAACcQAAAAEKOmil0lAirqKXcFVoSeBoO9joSMkZUh3pNkTaQ+FgLXtNkvV03q+vMN79k3WwCh+Q==", "61bea838-b688-438b-a883-90b0248436fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08effea3-4811-4e37-8c17-29f445b37dfa", "AQAAAAEAACcQAAAAEJVpnG9/jN4DWTpZALxq9GhOeAQi+eJ6Pf9wsg5+/K/Co5z9fBpOp/ZwdfGPIXUwqA==", "81180767-4572-4110-9527-f39f794f57fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8441d61c-6039-4211-a2d5-5d2bcaf0d5e8", "AQAAAAEAACcQAAAAENnaHnSFchpS/28VIIGJFCGocviThU4Aqn6nxf6L8NvB2wQkIa7qN5iGOG/n26f0dA==", "30f0aa6e-772c-469e-a6d5-8cfca9b0b6fb" });

            migrationBuilder.UpdateData(
                table: "Inquiries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 21, 16, 52, 27, 184, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "Inquiries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 21, 16, 52, 27, 184, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "ProgressStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 21, 16, 52, 27, 390, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "ProgressStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 21, 16, 52, 27, 390, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfResponse",
                value: new DateTime(2024, 4, 21, 16, 52, 27, 437, DateTimeKind.Local).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfResponse",
                value: new DateTime(2024, 4, 21, 16, 52, 27, 437, DateTimeKind.Local).AddTicks(1180));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "ClaimType",
                value: "FirstName");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClaimType",
                value: "FirstName");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "ClaimType",
                value: "FirstName");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "215b1ac8-ff39-4609-9fed-b270e466014e", "AQAAAAEAACcQAAAAEMNjdf/ITUHL5ZU7scDulgiwP41U7KEbZLjwEuoxSLEyUqjV9MMuD/F+/J79RL4CVQ==", "a07f4449-f189-4927-bdee-c1af3964bc5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31d7dc67-14c4-4e3b-8dee-4d4e7a9b027b", "AQAAAAEAACcQAAAAEO07JTgHKr5VXsDXEl/As+lU5UOHFVAGPVUfTlvF0DeDeucuVHFub5tGXnmy3wa87g==", "1bf8a6c6-6cc9-495a-9d10-d486a6188653" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b516ba9-004f-49ee-8cb6-e18fbcae29cb", "AQAAAAEAACcQAAAAEJLsEGvVmuKWMZ1h3WXKmLmIxtfF6+DDSgn/sMyxBH8alNISZ4CB10uvU08o7q09mQ==", "42decd72-d484-45ad-b5d6-d018179f0aa3" });

            migrationBuilder.UpdateData(
                table: "Inquiries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 21, 16, 28, 58, 458, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Inquiries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 21, 16, 28, 58, 458, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "ProgressStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 21, 16, 28, 58, 650, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "ProgressStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 21, 16, 28, 58, 650, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfResponse",
                value: new DateTime(2024, 4, 21, 16, 28, 58, 699, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfResponse",
                value: new DateTime(2024, 4, 21, 16, 28, 58, 699, DateTimeKind.Local).AddTicks(3330));
        }
    }
}
