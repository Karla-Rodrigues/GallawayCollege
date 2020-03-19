using Microsoft.EntityFrameworkCore.Migrations;

namespace KarlaR_300997958.Migrations
{
    public partial class FacultyCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FacultyCourse",
                table: "Faculties",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FacultyCourse",
                table: "Faculties");
        }
    }
}
