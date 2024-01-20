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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AvailableCopies = table.Column<int>(type: "int", nullable: false),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    { new Guid("02bc55be-9ce3-40bb-9daf-b2a8737d2a9c"), "Religious Texts, Spiritual Guidance", "Religious/Spiritual" },
                    { new Guid("034cbe4d-f3ab-43d9-91c1-574704f380f6"), "Picture Books, Middle Grade, Young Adult (YA)", "Children's and Young Adult" },
                    { new Guid("03de5718-fc5b-47ad-8c8b-a29775a36f04"), "Literary Fiction, Historical Fiction, Science Fiction (Sci-Fi), Fantasy, Mystery, Thriller, Horror, Romance", "Fiction" },
                    { new Guid("0c681cfe-c29b-448e-b148-a3fc6ce42184"), "Satirical Fiction, Comic Fiction", "Satire/Humor" },
                    { new Guid("53344cdb-ac0d-48d2-97dd-0b4413e44366"), "Business Books, Finance and Investing", "Business/Finance" },
                    { new Guid("535035d9-0480-4fb3-a13d-58a3e6713252"), "Tragedy, Comedy, Historical Drama", "Drama/Play" },
                    { new Guid("68fa12b3-9135-425d-8ac4-20b7be0a6a8f"), "Culinary Non-Fiction", "Cookbooks" },
                    { new Guid("6ddff644-a438-464d-b65d-5111d4b7c97d"), "Ancient History, Medieval, Renaissance", "Historical Fiction" },
                    { new Guid("7a9adc97-95a7-4f92-8554-ddfe7365352b"), "Narrative Poetry, Lyric Poetry, Haiku", "Poetry" },
                    { new Guid("7b22a916-6e56-4e05-8b77-3cc77b7ed978"), "Contemporary Romance, Historical Romance, Paranormal Romance", "Romance" },
                    { new Guid("87ef929a-c939-4842-a6d4-04230985ca93"), "Superhero Comics, Graphic Memoirs", "Graphic Novels/Comics" },
                    { new Guid("966f1381-e42e-47b7-a26c-6f5e8bb1c281"), "Action-Adventure, Historical Adventure", "Adventure" },
                    { new Guid("981499f3-f42d-43b0-a838-99979caaf74f"), "Detective Fiction, Crime Thriller, Psychological Thriller", "Mystery/Thriller" },
                    { new Guid("a261cd62-7818-486b-9ebe-9872ab73442b"), "Shonen, Shojo, Seinen, Josei", "Manga" },
                    { new Guid("c13f46c7-a2cb-4908-afa5-4839faeb36a8"), "High Fantasy, Urban Fantasy, Magical Realism", "Fantasy" },
                    { new Guid("c523a457-599c-446d-a959-2fd7b1b26c86"), " Space Opera, Cyberpunk, Hard Science Fiction", "Science Fiction (Sci-Fi)" },
                    { new Guid("cc02d990-0b55-4825-9c90-498ee5db75a2"), "Popular Science, Natural History", "Science/Nature" },
                    { new Guid("edc5b2a0-98bf-4c26-ad5e-c98898d7953c"), "Supernatural Horror, Psychological Horror, Gothic Horror", "Horror" },
                    { new Guid("f6dd5da1-54ff-42c7-b558-155ec81be904"), "Classic Literature", "Classics" },
                    { new Guid("f93f529f-61a4-4ca9-9369-57e57fb69897"), "Biography/Autobiography, Memoir, Essay, Self-Help, Psychology, Philosophy, History, Travel, Science, True Crime", "Non-Fiction" }
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
