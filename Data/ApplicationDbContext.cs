using Microsoft.EntityFrameworkCore;
using CDN_FreelancerDirectory.Models;

namespace CDN_FreelancerDirectory.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
