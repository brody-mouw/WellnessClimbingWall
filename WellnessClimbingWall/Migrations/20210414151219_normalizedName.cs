using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WellnessClimbingWall.Migrations
{
    public partial class normalizedName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "7cfaa566-1a51-4061-8fcd-40f1191003ef", "5d38058b-10d4-43c7-b829-73da4acdcbd9", "Administrators", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2bdced9e-a7a1-4d88-8209-5636a772fcdf", 0, "a66972a1-dc0a-41a5-a969-7b5253d9dda7", "temp@admin.com", false, false, null, null, "Administrator", "AQAAAAEAACcQAAAAEInuLQyyI95cq4bpZErF1sP3BveaQuQPz05BD/n1pTOae8gGbAjzt2J5qLypjvh3AA==", null, false, "7cc6d3b8-b764-4808-922b-c5c5a0433202", false, "Administrator" });

            migrationBuilder.UpdateData(
                table: "Visit",
                keyColumn: "ID",
                keyValue: 112233,
                columns: new[] { "timeIn", "timeOut" },
                values: new object[] { new DateTime(2021, 4, 14, 10, 12, 18, 572, DateTimeKind.Local).AddTicks(7879), new DateTime(2021, 4, 14, 10, 12, 18, 575, DateTimeKind.Local).AddTicks(3551) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7cfaa566-1a51-4061-8fcd-40f1191003ef", "2bdced9e-a7a1-4d88-8209-5636a772fcdf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cfaa566-1a51-4061-8fcd-40f1191003ef", "2bdced9e-a7a1-4d88-8209-5636a772fcdf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7cfaa566-1a51-4061-8fcd-40f1191003ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2bdced9e-a7a1-4d88-8209-5636a772fcdf");

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
    }
}
