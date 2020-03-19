using Microsoft.EntityFrameworkCore.Migrations;

namespace KarlaR_300997958.Migrations
{
    public partial class Courses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseCode = table.Column<string>(nullable: false),
                    CourseName = table.Column<string>(nullable: false),
                    CourseFaculty = table.Column<string>(nullable: true),
                    CourseDesc = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseCode);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
