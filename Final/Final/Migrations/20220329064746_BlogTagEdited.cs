using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Migrations
{
    public partial class BlogTagEdited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TagId",
                table: "BlogTags");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "BlogTags",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
