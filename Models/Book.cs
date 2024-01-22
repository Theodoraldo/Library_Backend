using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models;

public class Book : BaseEntity
{
    [Required]
    public required string Title { get; set; } 

    [Required]
    public required string Author { get; set; } 

    [Display(Name = "Published Date")]
    [DataType(DataType.Date)]
    public DateTime PublishedDate { get; set; }

    [Display(Name = "Available Copies")]
    public int AvailableCopies { get; set; }

    [Required]
    public int Pages { get; set; } 

    [Required]
    public required string Notes { get; set; } 

    [Display(Name = "Cover Image")]
    public byte[]? Image { get; set; } 

    // Foreign key for Genre
    public Guid GenreId { get; set; }
    public Genre Genre { get; set; } = default!;
}