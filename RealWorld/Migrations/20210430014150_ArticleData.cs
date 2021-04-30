using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RealWorld.Migrations
{
    public partial class ArticleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Body", "CreatedAt", "Description", "Slug", "TagList", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Article 1 body", new DateTimeOffset(new DateTime(2021, 4, 30, 1, 41, 49, 750, DateTimeKind.Unspecified).AddTicks(6363), new TimeSpan(0, 0, 0, 0, 0)), "Article 1 description", "article / 1", new[] { "Tag1", "Tag2" }, "Article 1", new DateTimeOffset(new DateTime(2021, 4, 30, 1, 41, 49, 750, DateTimeKind.Unspecified).AddTicks(6562), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Article 2 body", new DateTimeOffset(new DateTime(2021, 4, 30, 1, 41, 49, 750, DateTimeKind.Unspecified).AddTicks(7319), new TimeSpan(0, 0, 0, 0, 0)), "Article 2 description", "article / 2", new[] { "Tag3", "Tag4" }, "Article 2", new DateTimeOffset(new DateTime(2021, 4, 30, 1, 41, 49, 750, DateTimeKind.Unspecified).AddTicks(7321), new TimeSpan(0, 0, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));
        }
    }
}
