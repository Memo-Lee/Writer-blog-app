using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WriterDataAccess.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WriterId",
                table: "Writers",
                newName: "WriterID");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "Blogs",
                newName: "BlogID");

            migrationBuilder.AddColumn<int>(
                name: "BlogID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogID",
                table: "Comments",
                column: "BlogID");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryID",
                table: "Blogs",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Categories_CategoryID",
                table: "Blogs",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogs_BlogID",
                table: "Comments",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Categories_CategoryID",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_BlogID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_BlogID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_CategoryID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "BlogID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "WriterID",
                table: "Writers",
                newName: "WriterId");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "BlogID",
                table: "Blogs",
                newName: "BlogId");
        }
    }
}
