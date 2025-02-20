using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        [StringLength(100)]
        public required string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public required string LastName { get; set; }

        [StringLength(500)]
        public string? Biography { get; set; } // Optional

        // Navigation Property: One author can have multiple books
        public List<Book> Books { get; set; } = new();
    }
}
