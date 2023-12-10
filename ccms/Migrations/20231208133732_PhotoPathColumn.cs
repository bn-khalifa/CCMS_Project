using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ccms.Migrations
{
    public partial class PhotoPathColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "emp_photo_path",
                table: "Employee_table",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Employee_table",
                columns: new[] { "emp_id", "emp_email", "emp_name", "emp_password", "emp_photo_path" },
                values: new object[] { "E001", "john@example.com", "John mark", "password1", "path/photo.jpg" });

            migrationBuilder.InsertData(
                table: "Employee_table",
                columns: new[] { "emp_id", "emp_email", "emp_name", "emp_password", "emp_photo_path" },
                values: new object[] { "E002", "hoss@example.com", "Hossam Samy", "password2", "path/photo2.jpg" });

            migrationBuilder.InsertData(
                table: "Employee_table",
                columns: new[] { "emp_id", "emp_email", "emp_name", "emp_password", "emp_photo_path" },
                values: new object[] { "E003", "ahmed@example.com", "Ahmed Ali", "password3", "path/photo3.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee_table",
                keyColumn: "emp_id",
                keyValue: "E001");

            migrationBuilder.DeleteData(
                table: "Employee_table",
                keyColumn: "emp_id",
                keyValue: "E002");

            migrationBuilder.DeleteData(
                table: "Employee_table",
                keyColumn: "emp_id",
                keyValue: "E003");

            migrationBuilder.DropColumn(
                name: "emp_photo_path",
                table: "Employee_table");
        }
    }
}
