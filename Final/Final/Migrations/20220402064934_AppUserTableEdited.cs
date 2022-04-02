using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Migrations
{
    public partial class AppUserTableEdited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlbumTrack_Albums_AlbumId",
                table: "AlbumTrack");

            migrationBuilder.DropForeignKey(
                name: "FK_AlbumTrack_Genres_GenreId",
                table: "AlbumTrack");

            migrationBuilder.DropForeignKey(
                name: "FK_AlbumTrack_Singers_SingerId",
                table: "AlbumTrack");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AlbumTrack",
                table: "AlbumTrack");

            migrationBuilder.RenameTable(
                name: "AlbumTrack",
                newName: "Tracks");

            migrationBuilder.RenameIndex(
                name: "IX_AlbumTrack_SingerId",
                table: "Tracks",
                newName: "IX_Tracks_SingerId");

            migrationBuilder.RenameIndex(
                name: "IX_AlbumTrack_GenreId",
                table: "Tracks",
                newName: "IX_Tracks_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_AlbumTrack_AlbumId",
                table: "Tracks",
                newName: "IX_Tracks_AlbumId");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tracks",
                table: "Tracks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Albums_AlbumId",
                table: "Tracks",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Genres_GenreId",
                table: "Tracks",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Singers_SingerId",
                table: "Tracks",
                column: "SingerId",
                principalTable: "Singers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Albums_AlbumId",
                table: "Tracks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Genres_GenreId",
                table: "Tracks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Singers_SingerId",
                table: "Tracks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tracks",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Tracks",
                newName: "AlbumTrack");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_SingerId",
                table: "AlbumTrack",
                newName: "IX_AlbumTrack_SingerId");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_GenreId",
                table: "AlbumTrack",
                newName: "IX_AlbumTrack_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_AlbumId",
                table: "AlbumTrack",
                newName: "IX_AlbumTrack_AlbumId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlbumTrack",
                table: "AlbumTrack",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AlbumTrack_Albums_AlbumId",
                table: "AlbumTrack",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AlbumTrack_Genres_GenreId",
                table: "AlbumTrack",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AlbumTrack_Singers_SingerId",
                table: "AlbumTrack",
                column: "SingerId",
                principalTable: "Singers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
