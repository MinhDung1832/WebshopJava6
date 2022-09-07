using Microsoft.EntityFrameworkCore.Migrations;

namespace NET105_Tutorial_Csharp5_Dungna29.Migrations
{
    public partial class AddTableCountryV10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grade3s",
                columns: table => new
                {
                    Grade3Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade3s", x => x.Grade3Id);
                });

            migrationBuilder.CreateTable(
                name: "Grade4s",
                columns: table => new
                {
                    Grade4Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade4s", x => x.Grade4Id);
                });

            migrationBuilder.CreateTable(
                name: "Student3s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade3Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student3s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student3s_Grade3s_Grade3Id",
                        column: x => x.Grade3Id,
                        principalTable: "Grade3s",
                        principalColumn: "Grade3Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student4s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    Grade4Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student4s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student4s_Grade4s_Grade4Id",
                        column: x => x.Grade4Id,
                        principalTable: "Grade4s",
                        principalColumn: "Grade4Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student3s_Grade3Id",
                table: "Student3s",
                column: "Grade3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Student4s_Grade4Id",
                table: "Student4s",
                column: "Grade4Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student3s");

            migrationBuilder.DropTable(
                name: "Student4s");

            migrationBuilder.DropTable(
                name: "Grade3s");

            migrationBuilder.DropTable(
                name: "Grade4s");
        }
    }
}
