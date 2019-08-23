using Microsoft.EntityFrameworkCore;

namespace Cdc.Vocabulary.Entities
{
    public class CodeSystemContext : DbContext
    {
        public CodeSystemContext(DbContextOptions<CodeSystemContext> options)
           : base(options)
        {
            // Database.Migrate();
        }

        public DbSet<CodeSystem> CodeSystems { get; set; }

    }
}
