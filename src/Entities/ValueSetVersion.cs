using System;
using System.ComponentModel.DataAnnotations;

namespace Cdc.Vocabulary.Entities
{
    public sealed class ValueSetVersion
    {
        [Key]
        public Guid ValueSetVersionID { get; set; }

        public int ValueSetVersionNumber { get; set; } // minus 'number' in DB

        public string ValueSetVersionDescriptionText { get; set; } = string.Empty;

        public string StatusCode { get; set; } = string.Empty;

        public DateTimeOffset StatusDate { get; set; }

        public string AssigningAuthorityVersionText { get; set; } = string.Empty;

        public DateTimeOffset? AssigningAuthorityReleaseDate { get; set; }

        public string NoteText { get; set; } = string.Empty;

        public DateTimeOffset? EffectiveDate { get; set; }

        public DateTimeOffset? ExpiryDate { get; set; }

        public string ValueSetOID { get; set; } = string.Empty; // FK - ref ValueSet.ValueSetOID
    }
}
