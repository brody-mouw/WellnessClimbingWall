using Microsoft.EntityFrameworkCore.Migrations;

namespace WellnessClimbingWall.Migrations
{
    public partial class aVisit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Patron",
                columns: new[] { "ID", "Certifications", "Discriminator", "Name" },
                values: new object[] { 112233, "Belay", "Visit", "Chester" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patron",
                keyColumn: "ID",
                keyValue: 112233);
        }
    }
}
