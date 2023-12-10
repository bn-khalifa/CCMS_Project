using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ccms.Migrations
{
    public partial class Frist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee_table",
                columns: table => new
                {
                    emp_id = table.Column<string>(type: "varchar(15)", nullable: false),
                    emp_name = table.Column<string>(type: "varchar(20)", nullable: false),
                    emp_email = table.Column<string>(type: "varchar(20)", nullable: false),
                    emp_password = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_table", x => x.emp_id);
                });

            migrationBuilder.CreateTable(
                name: "History_table",
                columns: table => new
                {
                    history_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_id = table.Column<string>(type: "char(15)", nullable: false),
                    student_id = table.Column<string>(type: "char(15)", nullable: false),
                    time_in = table.Column<string>(type: "char(5)", nullable: false),
                    time_out = table.Column<string>(type: "char(5)", nullable: false),
                    date = table.Column<string>(type: "char(10)", nullable: false),
                    cost = table.Column<double>(type: "FLOAT(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History_table", x => x.history_id);
                });

            migrationBuilder.CreateTable(
                name: "In_student_table",
                columns: table => new
                {
                    in_student_id = table.Column<string>(type: "varchar(15)", nullable: false),
                    in_student_name = table.Column<string>(type: "varchar(20)", nullable: false),
                    in_time = table.Column<string>(type: "char(5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_In_student_table", x => x.in_student_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee_table");

            migrationBuilder.DropTable(
                name: "History_table");

            migrationBuilder.DropTable(
                name: "In_student_table");
        }
    }
}
