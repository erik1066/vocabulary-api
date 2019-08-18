using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cdc.Vocabulary.Entities
{
    public class ValueSet
    {
        [Key]
        public Guid Id { get; set; }

        public string Oid { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        public string Status { get; set; }

        public DateTimeOffset StatusDate { get; set; }

        [Required]
        public string DefinitionText { get; set; }

        public string ScopeNoteText { get; set; }

        public Guid AssigningAuthorityId { get; set; }

        public DateTimeOffset ValueSetCreatedDate { get; set; }

        public DateTimeOffset ValueSetLastRevisionDate { get; set; }
    }
}
