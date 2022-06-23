using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HskApi.Migrations
{
    public partial class UpdatedTodo1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "test",
                table: "TodoItems",
                newName: "test1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "test1",
                table: "TodoItems",
                newName: "test");
        }
    }
}
