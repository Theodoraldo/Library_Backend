using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class Book : BaseEntity
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Display(Name = "Published Date")]
        [DataType(DataType.Date)]
        public DateTime? PublishedDate { get; set; }

        [Display(Name = "Available Copies")]
        public int AvailableCopies { get; set; }

        public int Pages { get; set; }

        [Required]
        public string Notes { get; set; }

        [Display(Name = "Cover Image")]
        public string? ImageUrl { get; set; }

        // Navigation properties
        public virtual Genre Genre { get; set; }
        public virtual ICollection<BorrowHistory> BorrowHistories { get; set; }
    }
}
