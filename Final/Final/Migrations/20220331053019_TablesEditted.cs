using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Migrations
{
    public partial class TablesEditted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogTags_Tags_TagsId",
                table: "BlogTags");

            migrationBuilder.AlterColumn<int>(
                name: "TagsId",
                table: "BlogTags",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TagsId",
                table: "Blogs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_TagsId",
                table: "Blogs",
                column: "TagsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Tags_TagsId",
                table: "Blogs",
                column: "TagsId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogTags_Tags_TagsId",
                table: "BlogTags",
                column: "TagsId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Tags_TagsId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogTags_Tags_TagsId",
                table: "BlogTags");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_TagsId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "TagsId",
                table: "Blogs");

            migrationBuilder.AlterColumn<int>(
                name: "TagsId",
                table: "BlogTags",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_BlogTags_Tags_TagsId",
                table: "BlogTags",
                column: "TagsId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
