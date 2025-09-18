using Microsoft.EntityFrameworkCore;
using NZWalksAPI.Models.Domains;

namespace NZWalksAPI.Data
{
    public class NZWalksDBContext:DbContext
    {
        public NZWalksDBContext(DbContextOptions dbContextOptions) :base(dbContextOptions) 
        {
            
        }
        public DbSet<Difficulty> difficulties { get; set; }
        public DbSet<Region> regions { get; set; }
        public DbSet<Walks> walks { get; set; }
    }
}
