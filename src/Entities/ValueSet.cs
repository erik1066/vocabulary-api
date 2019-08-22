using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cdc.Vocabulary.Entities
{
    public class ValueSet
    {
        [Key]
        public Guid ValueSetID { get; set; }

        public string ValueSetOID { get; set; } = string.Empty;

        [Required]
        public string ValueSetName { get; set; } = string.Empty;

        [Required]
        public string ValueSetCode { get; set; } = string.Empty;

        public string? Status { get; set; }

        public DateTimeOffset StatusDate { get; set; }

        [Required]
        public string DefinitionText { get; set; } = string.Empty;

        public string? ScopeNoteText { get; set; }

        public Guid AssigningAuthorityID { get; set; }

        public DateTimeOffset ValueSetCreatedDate { get; set; }

        public DateTimeOffset ValueSetLastRevisionDate { get; set; }
    }
}
