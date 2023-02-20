using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AsmFinal.Models;

namespace AsmFinal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AsmFinal.Models.Book> Book { get; set; }
        public DbSet<AsmFinal.Models.Category> Category { get; set; }
        public DbSet<AsmFinal.Models.Order> Order { get; set; }
        public DbSet<AsmFinal.Models.User> User { get; set; }
    }
}