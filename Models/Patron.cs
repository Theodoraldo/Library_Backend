using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class Patron : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Contact { get; set; }

        [Required]
        public string Location { get; set; }

        // Navigation property
        public virtual ICollection<BorrowHistory> BorrowHistories { get; set; }

    }
}
