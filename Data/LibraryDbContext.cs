using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Data;


public class LibraryDbContext : DbContext
{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
    {
        
    }

    public DbSet<Genre> Genres { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Patron> Patrons { get; set; }
    public DbSet<BorrowHistory> BorrowHistories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>().HasData(
            new Genre { Id = Guid.NewGuid(), GenreName = "Fiction", Description = "Literary Fiction, Historical Fiction, Science Fiction (Sci-Fi), Fantasy, Mystery, Thriller, Horror, Romance" },
            new Genre { Id = Guid.NewGuid(), GenreName = "Non-Fiction", Description = "Biography/Autobiography, Memoir, Essay, Self-Help, Psychology, Philosophy, History, Travel, Science, True Crime" },
            new Genre { Id = Guid.NewGuid(), GenreName = "Poetry", Description ="Narrative Poetry, Lyric Poetry, Haiku" },
            new Genre { Id = Guid.NewGuid(), GenreName = "Children's and Young Adult", Description = "Picture Books, Middle Grade, Young Adult (YA)" },
            new Genre { Id = Guid.NewGuid(), GenreName = "Drama/Play", Description = "Tragedy, Comedy, Historical Drama" },
            new Genre { Id = Guid.NewGuid(), GenreName = "Mystery/Thriller", Description = "Detective Fiction, Crime Thriller, Psychological Thriller" },
            new Genre { Id = Guid.NewGuid(), GenreName = "Science Fiction (Sci-Fi)", Description = " Space Opera, Cyberpunk, Hard Science Fiction" },
            new Genre { Id = Guid.NewGuid(), GenreName = "Fantasy", Description = "High Fantasy, Urban Fantasy, Magical Realism" },
            new Genre { Id = Guid.NewGuid(), GenreName = "Romance", Description = "Contemporary Romance, Historical Romance, Paranormal Romance" },
            new Genre { Id = Guid.NewGuid(), GenreName = "Horror", Description = "Supernatural Horror, Psychological Horror, Gothic Horror" },
            new Genre { Id = Guid.NewGuid(), GenreName = "Historical Fiction", Description = "Ancient History, Medieval, Renaissance" },
            new Genre { Id = Guid.NewGuid(), GenreName = "Adventure", Description = "Action-Adventure, Historical Adventure" },
            new Genre { Id = Guid.NewGuid(), GenreName = "Satire/Humor", Description = "Satirical Fiction, Comic Fiction" },
            new Genre { Id = Guid.NewGuid(), GenreName = "Graphic Novels/Comics", Description = "Superhero Comics, Graphic Memoirs" },
            new Genre { Id = Guid.NewGuid(), GenreName = "Manga", Description = "Shonen, Shojo, Seinen, Josei" },
            new Genre { Id = Guid.NewGuid(), GenreName = "Classics", Description = "Classic Literature" },
            new Genre { Id = Guid.NewGuid(), GenreName = "Religious/Spiritual", Description = "Religious Texts, Spiritual Guidance" },
            new Genre { Id = Guid.NewGuid(), GenreName = "Business/Finance", Description = "Business Books, Finance and Investing" },
            new Genre { Id = Guid.NewGuid(), GenreName = "Cookbooks", Description = "Culinary Non-Fiction" },
            new Genre { Id = Guid.NewGuid(), GenreName = "Science/Nature", Description = "Popular Science, Natural History" }
        );
    }
}