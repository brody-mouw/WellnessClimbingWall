using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WellnessClimbingWall.Migrations
{
    public partial class newAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "91f817ac-6ad4-4b96-8c6f-2dedb9a13480", "fc78e368-8ede-4f75-bfa3-a356cd2f24fb", "Administrators", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "68221243-01f4-4850-bb84-b4d37f6d21fb", 0, "a9d57e90-48ae-4cf2-b309-3d1140b7577d", "temp@admin.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEMNHP8rDaXDC5HL+udMvbf21Dri0myqLlZUSluEbCqkeFh+wChAwGx2oinotUK5Eeg==", null, false, "1e082522-8a9a-44f2-b6bd-2f7585829b7e", false, "Administrator" });

            migrationBuilder.UpdateData(
                table: "Visit",
                keyColumn: "ID",
                keyValue: 112233,
                columns: new[] { "timeIn", "timeOut" },
                values: new object[] { new DateTime(2021, 4, 14, 9, 46, 25, 225, DateTimeKind.Local).AddTicks(3334), new DateTime(2021, 4, 14, 9, 46, 25, 228, DateTimeKind.Local).AddTicks(5731) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "91f817ac-6ad4-4b96-8c6f-2dedb9a13480", "68221243-01f4-4850-bb84-b4d37f6d21fb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91f817ac-6ad4-4b96-8c6f-2dedb9a13480", "68221243-01f4-4850-bb84-b4d37f6d21fb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91f817ac-6ad4-4b96-8c6f-2dedb9a13480");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68221243-01f4-4850-bb84-b4d37f6d21fb");

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
    }
}
