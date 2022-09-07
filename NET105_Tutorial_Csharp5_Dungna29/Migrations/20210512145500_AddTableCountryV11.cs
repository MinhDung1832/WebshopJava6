using Microsoft.EntityFrameworkCore.Migrations;

namespace NET105_Tutorial_Csharp5_Dungna29.Migrations
{
    public partial class AddTableCountryV11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student4s_Grade4s_Grade4Id",
                table: "Student4s");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "Student4s");

            migrationBuilder.AlterColumn<int>(
                name: "Grade4Id",
                table: "Student4s",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Student4s_Grade4s_Grade4Id",
                table: "Student4s",
                column: "Grade4Id",
                principalTable: "Grade4s",
                principalColumn: "Grade4Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student4s_Grade4s_Grade4Id",
                table: "Student4s");

            migrationBuilder.AlterColumn<int>(
                name: "Grade4Id",
                table: "Student4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "GradeId",
                table: "Student4s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Student4s_Grade4s_Grade4Id",
                table: "Student4s",
                column: "Grade4Id",
                principalTable: "Grade4s",
                principalColumn: "Grade4Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
