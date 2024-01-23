using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models;

public class Genre : BaseEntity
{
    [Required]
    public string GenreName { get; set; }

    [Required]
    public string? Description { get; set; } 

    // Navigation property
    public virtual ICollection<Book> Books { get; set; }
}