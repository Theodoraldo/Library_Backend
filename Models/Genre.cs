using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAPI.Models;

public class Genre : BaseEntity
{
    [Required]
    public string GenreName { get; set; }

    [Required]
    public string Description { get; set; } = null!; 
}