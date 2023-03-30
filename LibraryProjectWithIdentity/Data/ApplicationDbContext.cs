using LibraryProjectWithIdentity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryProjectWithIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrow> Borrows { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Borrow>()
                .HasOne<ApplicationUser>(o => o.ApplicationUser)
                .WithMany(c => c.Borrows)
                .HasForeignKey(b => b.ApplicationUserId);

            modelBuilder.Entity<Borrow>()
                .HasOne<Book>(b => b.BorrowBook)
                .WithMany(c => c.History)
                .HasForeignKey(b => b.BookId);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUser>().HasKey(u => u.Id);

            modelBuilder.Entity<Book>()
                .Property(b => b.Price)
                .HasPrecision(4, 2);
        }

    }
}