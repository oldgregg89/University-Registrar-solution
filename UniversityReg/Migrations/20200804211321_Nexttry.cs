using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityReg.Migrations
{
    public partial class Nexttry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>("EnrollmentDate", "Students", c=>c.String(nullable: false, defaultValueSql: "now()"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropTable(
            //     name: "CourseStudent");

            // migrationBuilder.DropTable(
            //     name: "Courses");

            // migrationBuilder.DropTable(
            //     name: "Students");
        }
    }
}
