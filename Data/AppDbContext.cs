using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mobin.Models;

namespace Mobin.Data
{
    public class AppDbContext : IdentityDbContext<Users>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
         : base(options)
        {

        }

        public DbSet<Users> Users {  get; set; }
    }
}
