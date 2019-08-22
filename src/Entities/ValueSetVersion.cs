using System;
using System.ComponentModel.DataAnnotations;

namespace Cdc.Vocabulary.Entities
{
    public class ValueSetVersion
    {
        [Key]
        public Guid ValueSetVersionID { get; set; }

        public int ValueSetVersionNumber { get; set; } // minus 'number' in DB

        public string ValueSetVersionDescriptionText { get; set; }

        public string StatusCode { get; set; }

        public DateTimeOffset StatusDate { get; set; }

        public string? AssigningAuthorityVersionText { get; set; }

        public DateTimeOffset? AssigningAuthorityReleaseDate { get; set; }

        public string? NoteText { get; set; }

        public DateTimeOffset? EffectiveDate { get; set; }

        public DateTimeOffset? ExpiryDate { get; set; }

        public string ValueSetOID { get; set; } // FK - ref ValueSet.ValueSetOID
    }
}
