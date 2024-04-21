using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediationCorner.Infrastructure.Migrations
{
    public partial class ClaimTypeChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35be685d-b14d-488c-81ce-5edce94e0b33", "AQAAAAEAACcQAAAAEC3dTLvg4tUDVBS/WaVuc3WXosNo/NFDv6YOo2dxqn2J9ErwCoyhj5ttS1Fqj5SJlQ==", "9e9a3770-ddd0-42fa-9f47-30fe80096cc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1e49245-136c-4f3c-ac7d-9d7322a82e72", "AQAAAAEAACcQAAAAENiO1KQ3AWvnwus1FjqiJmaJp+Gb6VzZKnXADawa1TOCPxrK5Sm/k3iM2BCJs2uEPg==", "ed369ee8-777a-4c6a-9b5a-98e1498754ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15d53adb-3758-47de-8216-c3dd84669dd3", "AQAAAAEAACcQAAAAEO5WMMZA5lEWnLqOVJW493NuJtzOETLl6WoBqe/CdVVy4um2iVQ82NZ9tnJi/0Srjw==", "f865b136-ac82-4129-ba3a-08870bc45ea8" });

            migrationBuilder.UpdateData(
                table: "Inquiries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 21, 16, 3, 16, 103, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Inquiries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 21, 16, 3, 16, 103, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "ProgressStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 21, 16, 3, 16, 267, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "ProgressStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 21, 16, 3, 16, 267, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfResponse",
                value: new DateTime(2024, 4, 21, 16, 3, 16, 317, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfResponse",
                value: new DateTime(2024, 4, 21, 16, 3, 16, 317, DateTimeKind.Local).AddTicks(8185));
        }
    }
}
