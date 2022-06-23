using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HskApi.Migrations
{
    public partial class UpdatedTodo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "test",
                table: "TodoItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "test",
                table: "TodoItems");
        }
    }
}
