using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Migrations
{
    public partial class BlogTagEditted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "BlogTags");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BlogTags",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
