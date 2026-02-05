using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicHub.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    ArtistName = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    AuthorName = table.Column<string>(type: "TEXT", nullable: false),
                    AuthorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    AlbumId = table.Column<int>(type: "INTEGER", nullable: false),
                    AlbumTitle = table.Column<string>(type: "TEXT", nullable: false),
                    AuthorName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ArtistName", "PasswordHash", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, "", "n4bQgYhMfWWaL+qgxVrQFaO/TxsrC4Is0V1sFbDwCgg=", "Admin", "Admin" },
                    { 2, "", "n4bQgYhMfWWaL+qgxVrQFaO/TxsrC4Is0V1sFbDwCgg=", "User", "User" },
                    { 3, "Post Malone", "n4bQgYhMfWWaL+qgxVrQFaO/TxsrC4Is0V1sFbDwCgg=", "Musician", "PostMalone" },
                    { 4, "Blink-182", "n4bQgYhMfWWaL+qgxVrQFaO/TxsrC4Is0V1sFbDwCgg=", "Musician", "Blink182" },
                    { 5, "Machine Gun Kelly", "n4bQgYhMfWWaL+qgxVrQFaO/TxsrC4Is0V1sFbDwCgg=", "Musician", "MachineGunKelly" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AuthorId", "AuthorName", "Title" },
                values: new object[,]
                {
                    { 1, 3, "", "Hollywood's Bleeding" },
                    { 2, 3, "", "Beerbongs & Bentleys" },
                    { 3, 4, "", "Enema Of The State" },
                    { 4, 4, "", "Take Off Your Pants And Jacket" },
                    { 5, 5, "", "Lost Americana" },
                    { 6, 5, "", "Tickets To My Downfall" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "AlbumTitle", "AuthorName", "Title" },
                values: new object[,]
                {
                    { 1, 1, "", "", "Hollywood’s Bleeding" },
                    { 2, 1, "", "", "Saint‑Tropez" },
                    { 3, 1, "", "", "Enemies (feat. DaBaby)" },
                    { 4, 1, "", "", "Allergic" },
                    { 5, 1, "", "", "A Thousand Bad Times" },
                    { 6, 1, "", "", "Circles" },
                    { 7, 1, "", "", "Die For Me (feat. Future & Halsey)" },
                    { 8, 2, "", "", "Paranoid" },
                    { 9, 2, "", "", "Spoil My Night (feat. Swae Lee)" },
                    { 10, 2, "", "", "Rich & Sad" },
                    { 11, 2, "", "", "Zack and Codeine" },
                    { 12, 2, "", "", "Takin’ Shots" },
                    { 13, 2, "", "", "Rockstar (feat. 21 Savage)" },
                    { 14, 2, "", "", "Over Now" },
                    { 15, 3, "", "", "Dumpweed" },
                    { 16, 3, "", "", "Don’t Leave Me" },
                    { 17, 3, "", "", "Aliens Exist" },
                    { 18, 3, "", "", "Going Away to College" },
                    { 19, 3, "", "", "What’s My Age Again?" },
                    { 20, 3, "", "", "Dysentery Gary" },
                    { 21, 3, "", "", "Adam’s Song" },
                    { 22, 4, "", "", "Anthem Part Two" },
                    { 23, 4, "", "", "Online Songs" },
                    { 24, 4, "", "", "First Date" },
                    { 25, 4, "", "", "Happy Holidays, You Bastard" },
                    { 26, 4, "", "", "Story of a Lonely Guy" },
                    { 27, 4, "", "", "The Rock Show" },
                    { 28, 6, "", "", "Title Song" },
                    { 29, 6, "", "", "Kiss Kiss" },
                    { 30, 6, "", "", "Drunk Face" },
                    { 31, 6, "", "", "Bloody Valentine" },
                    { 32, 6, "", "", "Forget Me Too (feat. Halsey)" },
                    { 33, 6, "", "", "All I Know (feat. Trippie Redd)" },
                    { 34, 6, "", "", "Lonely" },
                    { 35, 5, "", "", "Outlaw Overture" },
                    { 36, 5, "", "", "Cliché" },
                    { 37, 5, "", "", "Don’t Wait Run Fast" },
                    { 38, 5, "", "", "Goddamn" },
                    { 39, 5, "", "", "Vampire Diaries" },
                    { 40, 5, "", "", "Miss Sunshine" },
                    { 41, 5, "", "", "Sweet Coraline" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_AuthorId",
                table: "Albums",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs",
                column: "AlbumId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
