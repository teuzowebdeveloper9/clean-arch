using cleanarchteture.domain.entities;
using Microsoft.EntityFrameworkCore;

namespace cleanarchteture.persistence.context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        
        }
            public DbSet<User> users{ get; set; }

    }
}