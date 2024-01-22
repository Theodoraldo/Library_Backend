using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAPI.Models;

public class Genre : BaseEntity
{
    [Required]
    public required string GenreName { get; set; }

    [Required]
    public required string Description { get; set; } 
}