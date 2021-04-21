using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WellnessClimbingWall.Migrations
{
    public partial class badgeField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "BadgeNumber",
                table: "Patron",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7dbef6d7-ece5-4f8b-a848-627a5ce91937", "8d1422a5-1c17-4ec8-9548-9feca3ed7ae9", "Administrators", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f51c0777-3658-442e-8571-29f690839e23", 0, "040eb733-4fee-46dc-a243-85e2c0260cb4", "temp@admin.com", false, false, null, null, "Administrator", "AQAAAAEAACcQAAAAEGSdnib0DpYhFLKkwIqkdDCpccCUOBEVz96SjuGv3o6ir2880drQ0EYxAPu3HNgksg==", null, false, "94058c8c-4dc2-4389-a720-a2e2695c8e1f", false, "Administrator" });

            migrationBuilder.InsertData(
                table: "Patron",
                columns: new[] { "ID", "BadgeNumber", "Certifications", "Name" },
                values: new object[] { 1, 1234567, "None", "Miller Wallman" });

            migrationBuilder.UpdateData(
                table: "Visit",
                keyColumn: "ID",
                keyValue: 112233,
                columns: new[] { "timeIn", "timeOut" },
                values: new object[] { new DateTime(2021, 4, 21, 18, 9, 34, 209, DateTimeKind.Local).AddTicks(9718), new DateTime(2021, 4, 21, 18, 9, 34, 213, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7dbef6d7-ece5-4f8b-a848-627a5ce91937", "f51c0777-3658-442e-8571-29f690839e23" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7dbef6d7-ece5-4f8b-a848-627a5ce91937", "f51c0777-3658-442e-8571-29f690839e23" });

            migrationBuilder.DeleteData(
                table: "Patron",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7dbef6d7-ece5-4f8b-a848-627a5ce91937");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f51c0777-3658-442e-8571-29f690839e23");

            migrationBuilder.DropColumn(
                name: "BadgeNumber",
                table: "Patron");

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
    }
}
