using Microsoft.EntityFrameworkCore;

namespace Cdc.Vocabulary.Entities
{
    public class ValueSetVersionContext : DbContext
    {
        public ValueSetVersionContext(DbContextOptions<ValueSetVersionContext> options)
           : base(options)
        {
            // Database.Migrate();
        }

        public DbSet<ValueSetVersion> ValueSetVersions { get; set; }

    }
}
