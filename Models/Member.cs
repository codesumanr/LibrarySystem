using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        [Required]
        [StringLength(100)]
        public required string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public required string LastName { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [Phone]
        public required string PhoneNumber { get; set; }

        [Required]
        [StringLength(200)]
        public required string Address { get; set; }

        public DateTime MembershipDate { get; set; } = DateTime.UtcNow; // Default to current date

        // Navigation Property
        public List<Loan> Loans { get; set; } = new();
    }
}
