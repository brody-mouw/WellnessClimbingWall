using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WellnessClimbingWall.Migrations
{
    public partial class adminStuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36f39752-8f52-4773-928d-08ea117e8fb8", "cb658d50-094d-4970-b7c6-c1790e7858f8", "Administrators", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0d37671f-42ff-48b4-a0c6-8ec88eb9539b", 0, "982f570a-af4a-4f53-8b85-d91d11f8b4b8", null, false, false, null, null, null, "AQAAAAEAACcQAAAAEMdYKrAx4CZvn5BA5yC1I5EUay7soPLzrGe6DJC8b/hh63cuMyHKrQy4xSVSMkhJhg==", null, false, "22926c44-bcc2-4584-af10-f86cae17af71", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Visit",
                keyColumn: "ID",
                keyValue: 112233,
                columns: new[] { "timeIn", "timeOut" },
                values: new object[] { new DateTime(2021, 4, 13, 17, 39, 32, 631, DateTimeKind.Local).AddTicks(4672), new DateTime(2021, 4, 13, 17, 39, 32, 634, DateTimeKind.Local).AddTicks(363) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "36f39752-8f52-4773-928d-08ea117e8fb8", "0d37671f-42ff-48b4-a0c6-8ec88eb9539b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "36f39752-8f52-4773-928d-08ea117e8fb8", "0d37671f-42ff-48b4-a0c6-8ec88eb9539b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36f39752-8f52-4773-928d-08ea117e8fb8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d37671f-42ff-48b4-a0c6-8ec88eb9539b");

            migrationBuilder.UpdateData(
                table: "Visit",
                keyColumn: "ID",
                keyValue: 112233,
                columns: new[] { "timeIn", "timeOut" },
                values: new object[] { new DateTime(2021, 4, 7, 16, 15, 41, 268, DateTimeKind.Local).AddTicks(8024), new DateTime(2021, 4, 7, 16, 15, 41, 272, DateTimeKind.Local).AddTicks(2930) });
        }
    }
}
