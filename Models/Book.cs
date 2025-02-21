using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [StringLength(200)]
        public required string Title { get; set; }  // ✅ Required Modifier

        [Required]
        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual required Author Author { get; set; }  // ✅ Required Modifier

        [Required]
        [RegularExpression(@"^(97(8|9))?\d{9}(\d|X)$", 
            ErrorMessage = "ISBN must be 10 or 13 digits (e.g., 9783161484100 or 0316015849).")]
        [StringLength(13, MinimumLength = 10)]
        public required string ISBN { get; set; }  // ✅ Now with validation for ISBN-10 & ISBN-13

        public bool IsAvailable { get; set; } = true;
    }
}



namespace LibrarySystem.DTOs
{
    public class BookDTO
    {
        public int BookId { get; set; }
        public required string Title { get; set; }
        public required string ISBN { get; set; }
        public required string AuthorName { get; set; }
        public bool IsAvailable { get; set; }
    }
}

