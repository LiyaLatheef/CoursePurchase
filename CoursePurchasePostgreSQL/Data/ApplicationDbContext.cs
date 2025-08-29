using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CoursePurchasePostgreSQL.Models;

namespace CoursePurchasePostgreSQL.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CoursePurchasePostgreSQL.Models.Cart> Cart { get; set; } = default!;
    }
}
