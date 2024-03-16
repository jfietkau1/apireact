using Microsoft.EntityFrameworkCore;

namespace APIreactfun.Data
{
    public class BowlerContext: DbContext
    {

        public BowlerContext(DbContextOptions<BowlerContext> options) : base(options) { }

        public DbSet<Bowlers> Bowlers { get; set; }
        public DbSet<Teams> Teams { get; set; } 



    }
}
