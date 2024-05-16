using Code_Assessment.Models;
using Microsoft.EntityFrameworkCore;

namespace Code_Assessment.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<Role> Role { get; set; }


    }
}
