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
        public required Book Book { get; set; }  // Required to ensure it is assigned

        [Required]
        public int MemberId { get; set; }

        [ForeignKey("MemberId")]
        //public required Member Member { get; set; }  // Required to ensure it is assigned

        [Required]
        public DateTime LoanDate { get; set; } = DateTime.UtcNow;  // Default to current time

        public DateTime? ReturnDate { get; set; }  // Nullable, as the book may not be returned yet

        [Required]
        public bool IsReturned { get; set; } = false;  // Default to false

        public DateTime DueDate => LoanDate.AddDays(14);  // Assuming a 2-week loan period
    }
}
