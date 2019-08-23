using Microsoft.EntityFrameworkCore;

namespace Cdc.Vocabulary.Entities
{
    public class ValueSetConceptContext : DbContext
    {
        public ValueSetConceptContext(DbContextOptions<ValueSetConceptContext> options)
           : base(options)
        {
            // Database.Migrate();
        }

        public DbSet<ValueSetConcept> ValueSetConcepts { get; set; }

    }
}
