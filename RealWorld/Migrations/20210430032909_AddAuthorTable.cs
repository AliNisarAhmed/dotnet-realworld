using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RealWorld.Migrations
{
    public partial class AddAuthorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: true),
                    Bio = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Slug = table.Column<string>(type: "text", nullable: true),
                    Body = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    TagList = table.Column<string[]>(type: "text[]", nullable: true),
                    AuthorId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Article_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Bio", "Image", "Username" },
                values: new object[,]
                {
                    { new Guid("c9d4c012-49b6-410c-bc78-2d54a9991870"), "Software Developer", "unspash.com", "AliAhmed" },
                    { new Guid("c9d4c013-49b6-410c-bc78-2d54a9991870"), "Scheduling Coordinator", "unspash.com", "SamrahAkber" }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "Description", "Slug", "TagList", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), new Guid("c9d4c012-49b6-410c-bc78-2d54a9991870"), "Article 1 body", new DateTimeOffset(new DateTime(2021, 4, 30, 3, 29, 9, 395, DateTimeKind.Unspecified).AddTicks(562), new TimeSpan(0, 0, 0, 0, 0)), "Article 1 description", "article / 1", new[] { "Tag1", "Tag2" }, "Article 1", new DateTimeOffset(new DateTime(2021, 4, 30, 3, 29, 9, 395, DateTimeKind.Unspecified).AddTicks(773), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), new Guid("c9d4c013-49b6-410c-bc78-2d54a9991870"), "Article 2 body", new DateTimeOffset(new DateTime(2021, 4, 30, 3, 29, 9, 395, DateTimeKind.Unspecified).AddTicks(1661), new TimeSpan(0, 0, 0, 0, 0)), "Article 2 description", "article / 2", new[] { "Tag3", "Tag4" }, "Article 2", new DateTimeOffset(new DateTime(2021, 4, 30, 3, 29, 9, 395, DateTimeKind.Unspecified).AddTicks(1663), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_AuthorId",
                table: "Article",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "Author");
        }
    }
}
