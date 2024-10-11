namespace donuts.Data
{
    public class DonutDbContext : DbContext
    {
        public DonutDbContext(DbContextOptions<DonutDbContext> options) : base(options)
        {
        }

        public DbSet<Donuts> Donuts{ get; set; }
    }
}
