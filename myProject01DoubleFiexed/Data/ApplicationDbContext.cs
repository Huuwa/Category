using Microsoft.EntityFrameworkCore;
using myProject01DoubleFiexed.Models;

namespace myProject01DoubleFiexed.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
