using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Data;


public class LibraryDbContext : DbContext
{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
    {
        
    }

    public DbSet<Genre> Genres { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, GenreName = "Fiction", Description = "Literary Fiction, Historical Fiction, Science Fiction (Sci-Fi), Fantasy, Mystery, Thriller, Horror, Romance" },
                new Genre { Id = 2, GenreName = "Non-Fiction", Description = "Biography/Autobiography, Memoir, Essay, Self-Help, Psychology, Philosophy, History, Travel, Science, True Crime" },
                new Genre { Id = 3, GenreName = "Poetry", Description ="Narrative Poetry, Lyric Poetry, Haiku" },
                new Genre { Id = 4, GenreName = "Children's and Young Adult", Description = "Picture Books, Middle Grade, Young Adult (YA)" },
                new Genre { Id = 5, GenreName = "Drama/Play", Description = "Tragedy, Comedy, Historical Drama" },
                new Genre { Id = 6, GenreName = "Mystery/Thriller", Description = "Detective Fiction, Crime Thriller, Psychological Thriller" },
                new Genre { Id = 7, GenreName = "Science Fiction (Sci-Fi)", Description = " Space Opera, Cyberpunk, Hard Science Fiction" },
                new Genre { Id = 8, GenreName = "Fantasy", Description = "High Fantasy, Urban Fantasy, Magical Realism" },
                new Genre { Id = 9, GenreName = "Romance", Description = "Contemporary Romance, Historical Romance, Paranormal Romance" },
                new Genre { Id = 10, GenreName = "Horror", Description = "Supernatural Horror, Psychological Horror, Gothic Horror" },
                new Genre { Id = 11, GenreName = "Historical Fiction", Description = "Ancient History, Medieval, Renaissance" },
                new Genre { Id = 12, GenreName = "Adventure", Description = "Action-Adventure, Historical Adventure" },
                new Genre { Id = 13, GenreName = "Satire/Humor", Description = "Satirical Fiction, Comic Fiction" },
                new Genre { Id = 14, GenreName = "Graphic Novels/Comics", Description = "Superhero Comics, Graphic Memoirs" },
                new Genre { Id = 15, GenreName = "Manga", Description = "Shonen, Shojo, Seinen, Josei" },
                new Genre { Id = 16, GenreName = "Classics", Description = "Classic Literature" },
                new Genre { Id = 17, GenreName = "Religious/Spiritual", Description = "Religious Texts, Spiritual Guidance" },
                new Genre { Id = 18, GenreName = "Business/Finance", Description = "Business Books, Finance and Investing" },
                new Genre { Id = 19, GenreName = "Cookbooks", Description = "Culinary Non-Fiction" },
                new Genre { Id = 20, GenreName = "Science/Nature", Description = "Popular Science, Natural History" }
            );
        }
}