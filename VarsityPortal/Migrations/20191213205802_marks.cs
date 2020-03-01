using Microsoft.EntityFrameworkCore.Migrations;

namespace VarsityPortal.Migrations
{
    public partial class marks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnrollmentId",
                table: "Marks");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<int>(
                name: "EnrollmentId",
                table: "Marks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
