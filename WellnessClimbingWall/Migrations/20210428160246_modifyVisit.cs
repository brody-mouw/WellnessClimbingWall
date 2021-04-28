using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WellnessClimbingWall.Migrations
{
    public partial class modifyVisit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7dbef6d7-ece5-4f8b-a848-627a5ce91937", "f51c0777-3658-442e-8571-29f690839e23" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7dbef6d7-ece5-4f8b-a848-627a5ce91937");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f51c0777-3658-442e-8571-29f690839e23");

            migrationBuilder.AddColumn<int>(
                name: "studentID",
                table: "Visit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e4a40016-2654-46b2-abef-af855207409c", "a9c29d43-7fd1-435f-a6da-908a62f05295", "Administrators", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0df93063-85bb-42e8-a2c7-2ff08ae56d13", 0, "a2a7e71a-7bd3-4757-8d4d-3d627eb537c9", "temp@admin.com", false, false, null, null, "Administrator", "AQAAAAEAACcQAAAAENA4xd2HJA8KRi87e1B05H51E02yfwLTGttN32dnssgE6DowKTpNErclvrYfugA/Yw==", null, false, "96cc822e-6acf-494c-807c-9cab1f47c464", false, "Administrator" });

            migrationBuilder.UpdateData(
                table: "Visit",
                keyColumn: "ID",
                keyValue: 112233,
                columns: new[] { "timeIn", "timeOut" },
                values: new object[] { new DateTime(2021, 4, 28, 11, 2, 46, 52, DateTimeKind.Local).AddTicks(6269), new DateTime(2021, 4, 28, 11, 2, 46, 55, DateTimeKind.Local).AddTicks(1875) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e4a40016-2654-46b2-abef-af855207409c", "0df93063-85bb-42e8-a2c7-2ff08ae56d13" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e4a40016-2654-46b2-abef-af855207409c", "0df93063-85bb-42e8-a2c7-2ff08ae56d13" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4a40016-2654-46b2-abef-af855207409c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0df93063-85bb-42e8-a2c7-2ff08ae56d13");

            migrationBuilder.DropColumn(
                name: "studentID",
                table: "Visit");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7dbef6d7-ece5-4f8b-a848-627a5ce91937", "8d1422a5-1c17-4ec8-9548-9feca3ed7ae9", "Administrators", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f51c0777-3658-442e-8571-29f690839e23", 0, "040eb733-4fee-46dc-a243-85e2c0260cb4", "temp@admin.com", false, false, null, null, "Administrator", "AQAAAAEAACcQAAAAEGSdnib0DpYhFLKkwIqkdDCpccCUOBEVz96SjuGv3o6ir2880drQ0EYxAPu3HNgksg==", null, false, "94058c8c-4dc2-4389-a720-a2e2695c8e1f", false, "Administrator" });

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
    }
}
