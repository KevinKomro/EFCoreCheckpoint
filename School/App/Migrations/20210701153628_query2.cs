using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class query2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
/*             migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Year = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    CourseName = table.Column<string>(type: "TEXT", nullable: true),
                    Grade = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "Year" },
                values: new object[] { 1, 19, "Buzz", "Liteya", "Freshman" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "Year" },
                values: new object[] { 2, 23, "Rick", "Ziggler", "Senior" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "Year" },
                values: new object[] { 3, 21, "Sheila", "Jinkees", "Junior" });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseName", "Grade", "StudentId" },
                values: new object[] { 1, "Science 233", 0.87, 1 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseName", "Grade", "StudentId" },
                values: new object[] { 2, "Comp Sci 1240", 0.94999999999999996, 1 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseName", "Grade", "StudentId" },
                values: new object[] { 3, "Math 303", 0.65000000000000002, 2 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseName", "Grade", "StudentId" },
                values: new object[] { 4, "History 102", 0.98999999999999999, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId"); */
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
/*             migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Students"); */
        }
    }
}
