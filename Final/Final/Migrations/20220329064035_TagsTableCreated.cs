using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Migrations
{
    public partial class TagsTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "BlogTags",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TagsId",
                table: "BlogTags",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogTags_TagsId",
                table: "BlogTags",
                column: "TagsId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogTags_Tags_TagsId",
                table: "BlogTags",
                column: "TagsId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogTags_Tags_TagsId",
                table: "BlogTags");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_BlogTags_TagsId",
                table: "BlogTags");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "BlogTags");

            migrationBuilder.DropColumn(
                name: "TagsId",
                table: "BlogTags");
        }
    }
}
