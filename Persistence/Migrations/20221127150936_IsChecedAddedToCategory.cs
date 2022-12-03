using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTasks.Data.Migrations
{
    public partial class IsChecedAddedToCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "Categories",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "Categories");
        }
    }
}
