using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WellnessClimbingWall.Migrations
{
    public partial class changeVisit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patron",
                keyColumn: "ID",
                keyValue: 112233);

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Patron");

            migrationBuilder.CreateTable(
                name: "Visit",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Certifications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    timeIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    timeOut = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visit", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Visit",
                columns: new[] { "ID", "Certifications", "Name", "timeIn", "timeOut" },
                values: new object[] { 112233, "Belay", "Chester", new DateTime(2021, 4, 7, 16, 15, 41, 268, DateTimeKind.Local).AddTicks(8024), new DateTime(2021, 4, 7, 16, 15, 41, 272, DateTimeKind.Local).AddTicks(2930) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visit");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Patron",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Patron",
                columns: new[] { "ID", "Certifications", "Discriminator", "Name" },
                values: new object[] { 112233, "Belay", "Visit", "Chester" });
        }
    }
}
