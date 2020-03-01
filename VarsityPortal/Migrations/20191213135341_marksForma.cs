using Microsoft.EntityFrameworkCore.Migrations;

namespace VarsityPortal.Migrations
{
    public partial class marksForma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Enrollments_EnrollmentSectionId_EnrollmentStudentId",
                table: "Marks");

            migrationBuilder.AlterColumn<string>(
                name: "ExamName",
                table: "Marks",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EnrollmentStudentId",
                table: "Marks",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EnrollmentSectionId",
                table: "Marks",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnrollmentId",
                table: "Marks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "OutOf",
                table: "Marks",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Enrollments_EnrollmentSectionId_EnrollmentStudentId",
                table: "Marks",
                columns: new[] { "EnrollmentSectionId", "EnrollmentStudentId" },
                principalTable: "Enrollments",
                principalColumns: new[] { "SectionId", "StudentId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Enrollments_EnrollmentSectionId_EnrollmentStudentId",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "EnrollmentId",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "OutOf",
                table: "Marks");

            migrationBuilder.AlterColumn<string>(
                name: "ExamName",
                table: "Marks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "EnrollmentStudentId",
                table: "Marks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EnrollmentSectionId",
                table: "Marks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Enrollments_EnrollmentSectionId_EnrollmentStudentId",
                table: "Marks",
                columns: new[] { "EnrollmentSectionId", "EnrollmentStudentId" },
                principalTable: "Enrollments",
                principalColumns: new[] { "SectionId", "StudentId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
