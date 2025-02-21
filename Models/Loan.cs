using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Models
{
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }

        [Required]
        public int BookId { get; set; }

        [ForeignKey("BookId")]
        public required Book Book { get; set; }

        [Required]
        public int MemberId { get; set; }

        [ForeignKey("MemberId")]
        public required Member Member { get; set; }  // Add this to resolve the error

        [Required]
        public DateTime LoanDate { get; set; } = DateTime.UtcNow;

        public DateTime? ReturnDate { get; set; }

        [Required]
        public bool IsReturned { get; set; } = false;

        public DateTime DueDate => LoanDate.AddDays(14);
    }
}
namespace LibrarySystem.DTOs
{
    public class LoanDTO
    {
        public int LoanId { get; set; }
        public required string BookTitle { get; set; }
        public required string MemberName { get; set; }  // Ensure this is correctly referenced
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
