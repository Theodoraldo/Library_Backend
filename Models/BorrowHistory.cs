using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class BorrowHistory : BaseEntity
    {
    // Navigation properties
    public virtual Book Book { get; set; }
    
    public virtual Patron Patron { get; set; }

    [Required]
    public string? BookState { get; set; }

    [Required]
    public DateTime BorrowDate { get; set; }

    public DateTime? ReturnDate { get; set; }
    }
}
