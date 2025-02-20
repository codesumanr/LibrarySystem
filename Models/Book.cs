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
        [StringLength(20)]
        public required string ISBN { get; set; }  // ✅ Required Modifier

        public bool IsAvailable { get; set; } = true;
    }
}
