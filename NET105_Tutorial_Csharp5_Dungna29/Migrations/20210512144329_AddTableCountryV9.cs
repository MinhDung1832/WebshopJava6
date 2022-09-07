using Microsoft.EntityFrameworkCore.Migrations;

namespace NET105_Tutorial_Csharp5_Dungna29.Migrations
{
    public partial class AddTableCountryV9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grade2s",
                columns: table => new
                {
                    Grade2Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade2s", x => x.Grade2Id);
                });

            migrationBuilder.CreateTable(
                name: "Student2s",
                columns: table => new
                {
                    Student2Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade2Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student2s", x => x.Student2Id);
                    table.ForeignKey(
                        name: "FK_Student2s_Grade2s_Grade2Id",
                        column: x => x.Grade2Id,
                        principalTable: "Grade2s",
                        principalColumn: "Grade2Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student2s_Grade2Id",
                table: "Student2s",
                column: "Grade2Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student2s");

            migrationBuilder.DropTable(
                name: "Grade2s");
        }
    }
}
