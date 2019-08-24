using Microsoft.EntityFrameworkCore;

namespace Cdc.Vocabulary.Entities
{
    public class VocabularyContext : DbContext
    {
        public VocabularyContext(DbContextOptions<VocabularyContext> options)
           : base(options)
        {
            // Database.Migrate();
        }

        public DbSet<ValueSetVersion> ValueSetVersions { get; set; }

        public DbSet<ValueSetConcept> ValueSetConcepts { get; set; }

        public DbSet<ValueSet> ValueSets { get; set; }

        public DbSet<CodeSystem> CodeSystems { get; set; }

    }
}
