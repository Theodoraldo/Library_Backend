using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public byte[] Image { get; set; }

        [ForeignKey("Genre")]
        public Guid GenreId { get; set; }
        public Genre Genre { get; set; } 
    }
}
