using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WellnessClimbingWall.Migrations
{
    public partial class addPatron : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2697de2e-9015-4bc2-8e5c-fcb38bfbb7f5", "e4afcaa4-5b54-4e27-b815-237ec9c2c2ce" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2697de2e-9015-4bc2-8e5c-fcb38bfbb7f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4afcaa4-5b54-4e27-b815-237ec9c2c2ce");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a7425926-0fa2-4475-bec2-965641877d6d", "803e7e71-6131-4bf5-82a8-485eeeab73c3", "Administrators", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cfefc59a-f647-400c-b1c3-60bf347d4774", 0, "1bd36d73-3486-4f7a-ba84-fe23385e69dc", "temp@admin.com", false, false, null, null, "Administrator", "AQAAAAEAACcQAAAAELS4SoGnmYBKieN2wyPa0xtwwu3hQw95d9uv6YyhJpk4vRVULC0lIWVZ/YXeKZWD6Q==", null, false, "2f46774d-9e33-4e4b-b79f-db989ba4f4f5", false, "Administrator" });

            migrationBuilder.InsertData(
                table: "Patron",
                columns: new[] { "ID", "Certifications", "Name" },
                values: new object[] { 78932, "None", "Miller Wallman" });

            migrationBuilder.UpdateData(
                table: "Visit",
                keyColumn: "ID",
                keyValue: 112233,
                columns: new[] { "timeIn", "timeOut" },
                values: new object[] { new DateTime(2021, 4, 21, 17, 27, 32, 907, DateTimeKind.Local).AddTicks(8350), new DateTime(2021, 4, 21, 17, 27, 32, 910, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a7425926-0fa2-4475-bec2-965641877d6d", "cfefc59a-f647-400c-b1c3-60bf347d4774" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a7425926-0fa2-4475-bec2-965641877d6d", "cfefc59a-f647-400c-b1c3-60bf347d4774" });

            migrationBuilder.DeleteData(
                table: "Patron",
                keyColumn: "ID",
                keyValue: 78932);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7425926-0fa2-4475-bec2-965641877d6d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfefc59a-f647-400c-b1c3-60bf347d4774");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2697de2e-9015-4bc2-8e5c-fcb38bfbb7f5", "da0feda6-4f88-4568-bdb7-4357ef3b6cc3", "Administrators", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e4afcaa4-5b54-4e27-b815-237ec9c2c2ce", 0, "78f89a20-d04f-40b4-950f-2a22170eabb1", "temp@admin.com", false, false, null, null, "Administrator", "AQAAAAEAACcQAAAAEMzhGjpOu2i4Bq88fn/SjLpDKYDalyUzIz+L/KUU7vu1xgbJV7MFwNv66d25Yco/Yg==", null, false, "47c29bec-50c2-403b-b2e3-ec15a586c610", false, "Administrator" });

            migrationBuilder.UpdateData(
                table: "Visit",
                keyColumn: "ID",
                keyValue: 112233,
                columns: new[] { "timeIn", "timeOut" },
                values: new object[] { new DateTime(2021, 4, 14, 10, 33, 55, 187, DateTimeKind.Local).AddTicks(7816), new DateTime(2021, 4, 14, 10, 33, 55, 191, DateTimeKind.Local).AddTicks(915) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2697de2e-9015-4bc2-8e5c-fcb38bfbb7f5", "e4afcaa4-5b54-4e27-b815-237ec9c2c2ce" });
        }
    }
}
