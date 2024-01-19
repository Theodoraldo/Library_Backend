using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedGenreTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
