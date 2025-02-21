using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace LibrarySystem.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        [StringLength(100)]
        public required string Name { get; set; }  // ✅ Fix: Add Name property

        public virtual ICollection<Book>? Books { get; set; }
    }
}
namespace LibrarySystem.DTOs
{
    public class AuthorDTO
    {
        public int AuthorId { get; set; }
        public required string Name { get; set; }
    }
}
