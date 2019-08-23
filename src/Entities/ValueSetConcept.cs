using System;
using System.ComponentModel.DataAnnotations;

namespace Cdc.Vocabulary.Entities
{
    public class ValueSetConcept
    {
        [Key]
        public Guid ValueSetConceptID { get; set; }

        public string? CodeSystemConceptName { get; set; }

        public string ValueSetConceptStatusCode { get; set; } = string.Empty; // FK3 - VocabularyObjectStatusLookup.StatusCode

        public DateTimeOffset ValueSetConceptStatusDate { get; set; }

        public string ValueSetConceptDefinitionText { get; set; } = string.Empty;

        public string CDCPreferredDesignation { get; set; } = string.Empty;

        public string ScopeNoteText { get; set; } = string.Empty;

        public Guid ValueSetVersionID { get; set; } // FK2 - ValueSetVersion.ValueSetVersionID

        public string CodeSystemOID { get; set; } = string.Empty; // FK1 - CodeSystemConcept.CodeSystemOID

        public string ConceptCode { get; set; } = string.Empty; // FK1 - CodeSystemConcept.ConceptCode

        public int? Sequence { get; set; }
    }
}
