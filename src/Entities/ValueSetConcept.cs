using System;
using System.ComponentModel.DataAnnotations;

namespace Cdc.Vocabulary.Entities
{
    public class ValueSetConcept
    {
        [Key]
        public Guid ValueSetConceptID { get; set; }

        public string? CodeSystemConceptName { get; set; }

        public string ValueSetConceptStatusCode { get; set; } // FK3 - VocabularyObjectStatusLookup.StatusCode

        public DateTimeOffset ValueSetConceptStatusDate { get; set; }

        public string? ValueSetConceptDefinitionText { get; set; }

        public string? CDCPreferredDesignation { get; set; }

        public string? ScopeNoteText { get; set; }

        public Guid ValueSetVersionID { get; set; } // FK2 - ValueSetVersion.ValueSetVersionID

        public string CodeSystemOID { get; set; } // FK1 - CodeSystemConcept.CodeSystemOID

        public string ConceptCode { get; set; } // FK1 - CodeSystemConcept.ConceptCode

        public int? Sequence { get; set; }
    }
}
