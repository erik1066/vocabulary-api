using System;
using System.Collections.Generic;

namespace Cdc.Vocabulary.Entities
{
    public static partial class VocabularyContextExtensions
    {
        public static void EnsureSeedDataForContext(this VocabularyContext context)
        {
            EnsureSeedDataForValueSets(context);
            EnsureSeedDataForValueSetVersions(context);
            EnsureSeedDataForValueSetConcepts(context);
            EnsureSeedDataForCodeSystems(context);
        }
    }
}