using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models;

public class Genre
{
    public int Id { get; set; }

    [Required]
    public string? GenreName { get; set; }

    [Required]
    public string? Description { get; set; } 
}