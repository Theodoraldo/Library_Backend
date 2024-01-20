using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitailDBCreateGenreBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AvailableCopies = table.Column<int>(type: "int", nullable: false),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description", "GenreName" },
                values: new object[,]
                {
                    { 1, "Literary Fiction, Historical Fiction, Science Fiction (Sci-Fi), Fantasy, Mystery, Thriller, Horror, Romance", "Fiction" },
                    { 2, "Biography/Autobiography, Memoir, Essay, Self-Help, Psychology, Philosophy, History, Travel, Science, True Crime", "Non-Fiction" },
                    { 3, "Narrative Poetry, Lyric Poetry, Haiku", "Poetry" },
                    { 4, "Picture Books, Middle Grade, Young Adult (YA)", "Children's and Young Adult" },
                    { 5, "Tragedy, Comedy, Historical Drama", "Drama/Play" },
                    { 6, "Detective Fiction, Crime Thriller, Psychological Thriller", "Mystery/Thriller" },
                    { 7, " Space Opera, Cyberpunk, Hard Science Fiction", "Science Fiction (Sci-Fi)" },
                    { 8, "High Fantasy, Urban Fantasy, Magical Realism", "Fantasy" },
                    { 9, "Contemporary Romance, Historical Romance, Paranormal Romance", "Romance" },
                    { 10, "Supernatural Horror, Psychological Horror, Gothic Horror", "Horror" },
                    { 11, "Ancient History, Medieval, Renaissance", "Historical Fiction" },
                    { 12, "Action-Adventure, Historical Adventure", "Adventure" },
                    { 13, "Satirical Fiction, Comic Fiction", "Satire/Humor" },
                    { 14, "Superhero Comics, Graphic Memoirs", "Graphic Novels/Comics" },
                    { 15, "Shonen, Shojo, Seinen, Josei", "Manga" },
                    { 16, "Classic Literature", "Classics" },
                    { 17, "Religious Texts, Spiritual Guidance", "Religious/Spiritual" },
                    { 18, "Business Books, Finance and Investing", "Business/Finance" },
                    { 19, "Culinary Non-Fiction", "Cookbooks" },
                    { 20, "Popular Science, Natural History", "Science/Nature" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
