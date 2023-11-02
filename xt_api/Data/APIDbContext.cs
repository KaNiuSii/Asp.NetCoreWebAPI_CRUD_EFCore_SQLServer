using Microsoft.EntityFrameworkCore;
using xt_api.Models;

namespace xt_api.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions option) : base(option)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
