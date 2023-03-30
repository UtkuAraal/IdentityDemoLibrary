using System.ComponentModel.DataAnnotations;

namespace LibraryProjectWithIdentity.Models
{
    public class Borrow
    {
        [Key]
        public int Id { get; set; }

        
        public int BookId { get; set; }
        public Book BorrowBook { get; set; }

        public DateTime CheckedOutDate { get; set; } = DateTime.Today;

        public DateTime ExpectedReturnDate { get; set; } = DateTime.Today.AddDays(15);

        public DateTime ActualReturnDate { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
