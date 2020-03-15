using Microsoft.EntityFrameworkCore.Migrations;

namespace AspAssignment.Migrations
{
    public partial class Commenttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    Comment_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Post_Id = table.Column<int>(nullable: false),
                    comments = table.Column<string>(nullable: true),
                    PostsPost_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.Comment_Id);
                    table.ForeignKey(
                        name: "FK_comments_Post_PostsPost_Id",
                        column: x => x.PostsPost_Id,
                        principalTable: "Post",
                        principalColumn: "Post_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "comments",
                columns: new[] { "Comment_Id", "Post_Id", "PostsPost_Id", "comments" },
                values: new object[,]
                {
                    { 1, 1, null, "Reply To Your first Post" },
                    { 2, 2, null, "Reply To Your second Post" },
                    { 3, 1, null, "Reply To Your first Post but second time" },
                    { 4, 3, null, "Reply To Your third Post" },
                    { 5, 3, null, "Reply To Your third Post but second time" },
                    { 6, 2, null, "Reply To the Post" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_comments_PostsPost_Id",
                table: "comments",
                column: "PostsPost_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comments");
        }
    }
}
