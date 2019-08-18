using Microsoft.EntityFrameworkCore;

namespace Cdc.Vocabulary.Entities
{
    public class ValueSetContext : DbContext
    {
        public ValueSetContext(DbContextOptions<ValueSetContext> options)
           : base(options)
        {
            // Database.Migrate();
        }

        public DbSet<ValueSet> ValueSets { get; set; }

    }
}
