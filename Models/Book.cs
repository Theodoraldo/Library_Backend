using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAPI.Models;

public class Book
{
    public int Id { get; set; }

    [Required]
    public string? Title { get; set; } 

    [Required]
    public string? Author { get; set; } 

    [Display(Name = "Published Date")]
    [DataType(DataType.Date)]
    public DateTime PublishedDate { get; set; }

    [Display(Name = "Available Copies")]
    public int AvailableCopies { get; set; }

    [Required]
    public string? Pages { get; set; } 

    [Required]
    public string? Notes { get; set; } 

    [Required]
    public int GenreId { get; set; } 

    [ForeignKey("GenreId")]
    public Genre? Genre { get; set; } 
}