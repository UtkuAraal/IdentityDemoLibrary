using Microsoft.AspNetCore.Identity;

using System.ComponentModel.DataAnnotations;

namespace LibraryProjectWithIdentity.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        public string TCKN { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        public ICollection<Borrow> Borrows { get; set; }
    }
}
