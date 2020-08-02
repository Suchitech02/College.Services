using Microsoft.EntityFrameworkCore.Migrations;

namespace College.Services.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Professors",
                columns: table => new
                {
                    ProfessorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Doj = table.Column<string>(nullable: true),
                    Teaches = table.Column<string>(nullable: true),
                    Salary = table.Column<decimal>(nullable: false),
                    IsPhd = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professors", x => x.ProfessorId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    RollNumber = table.Column<string>(nullable: true),
                    ProfessorId = table.Column<int>(nullable: false),
                    Fees = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Professors_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professors",
                        principalColumn: "ProfessorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Professors",
                columns: new[] { "ProfessorId", "Doj", "IsPhd", "Name", "Salary", "Teaches" },
                values: new object[] { 1, "29-11-23", true, "sandeep", 222m, "Shakespeare" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Fees", "Name", "ProfessorId", "RollNumber" },
                values: new object[] { 1, 224m, "sand", 1, "123" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Fees", "Name", "ProfessorId", "RollNumber" },
                values: new object[] { 2, 224m, "san", 1, "1243" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Fees", "Name", "ProfessorId", "RollNumber" },
                values: new object[] { 3, 224m, "sa", 1, "1243" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ProfessorId",
                table: "Students",
                column: "ProfessorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Professors");
        }
    }
}
