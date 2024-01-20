using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAPI.Models;

public class Book
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

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

    [Required]
    public Guid GenreId { get; set; } 

    [ForeignKey("GenreId")]
    public required Genre Genre { get; set; } 

    [Display(Name = "Cover Image")]
    public byte[]? Image { get; set; } 
}