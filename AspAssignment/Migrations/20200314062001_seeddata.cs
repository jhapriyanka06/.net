using Microsoft.EntityFrameworkCore.Migrations;

namespace AspAssignment.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Post_Id", "Comments", "Likes", "Post", "UserName", "userID" },
                values: new object[,]
                {
                    { 1, 6, 0, "This Is My First Post...Thankyou", "jha@06", null },
                    { 2, 8, 0, "This Is Shusnavi's First Post...Thankyou", "shus@16", null },
                    { 3, 5, 0, "Thankyou For Reading My First Post", "sweta@26", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userID", "UserName" },
                values: new object[,]
                {
                    { 1, "jha@06" },
                    { 2, "shus@16" },
                    { 3, "sweta@26" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Post_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Post_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Post_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "userID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "userID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "userID",
                keyValue: 3);
        }
    }
}
