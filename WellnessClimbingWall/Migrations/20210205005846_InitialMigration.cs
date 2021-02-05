using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WellnessClimbingWall.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Route",
                columns: table => new
                {
                    RouteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rope = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Setter = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Route", x => x.RouteId);
                });

            migrationBuilder.InsertData(
                table: "Route",
                columns: new[] { "RouteId", "Color", "DateCreated", "Grade", "Location", "Rope", "Setter" },
                values: new object[,]
                {
                    { 1, "Blue", new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "5.5", "None", 21, "John" },
                    { 2, "Red", new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "8.2", "None", 6, "Jack" },
                    { 3, "Yellow", new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "4.9", "North Wall", 0, "Charlie" },
                    { 4, "Black", new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "9.2", "None", 11, "Stacy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Route");
        }
    }
}
