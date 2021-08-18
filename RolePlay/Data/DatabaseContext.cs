using Microsoft.EntityFrameworkCore;
using RolePlay.Models;

namespace RolePlay.Data
{
    public class DatabaseContext:DbContext
    {
        
        public DatabaseContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Character> Characters{get;set;}
    }
}